using ApplicationCore.Exceptions;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using ApplicationCore.Entities;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IFavoriteRepository _favoriteRepository;
        private readonly IReviewRepository _reviewRepository;

        public UserService(IUserRepository userRepository, IPurchaseRepository purchaseRepository, IFavoriteRepository favoriteRepository, IReviewRepository reviewRepository)
        {
            _userRepository = userRepository;
            _purchaseRepository = purchaseRepository;
            _favoriteRepository = favoriteRepository;
            _reviewRepository = reviewRepository;
        }

        public async Task<FavoriteResponseModel> FavoriteMovie(FavoriteRequestModel model)
        {
            var exist = await _favoriteRepository.GetExistsAsync(f => f.MovieId == model.MovieId && f.UserId == model.UserId);
            if (exist)
            {
                throw new Exception("This user has already favorite this movie");
            }
            var favorite = new Favorite { MovieId = model.MovieId, UserId = model.UserId };
            var createdFavorite = await _favoriteRepository.AddAsync(favorite);
            var favoriteResponse = new FavoriteResponseModel { Id = createdFavorite.Id, MovieId = createdFavorite.MovieId, UserId = createdFavorite.UserId };
            return favoriteResponse;
        }

        public async Task<MovieDetailsResponseModel> GetFavoriteMovieDetails(int userId, int movieId)
        {
            var favorite = await _favoriteRepository.GetFavoriteMovieDetails(userId, movieId);
            if (favorite == null)
            {
                throw new Exception("This user did not favorite this movie");
            }
            var movieDetails = new MovieDetailsResponseModel
            {
                Id = favorite.Movie.Id,
                Title = favorite.Movie.Title,
                Overview = favorite.Movie.Overview,
                Budget = favorite.Movie.Budget,
                Revenue = favorite.Movie.Revenue,
                PosterUrl = favorite.Movie.PosterUrl,
                ReleaseDate = favorite.Movie.ReleaseDate,
                RunTime = favorite.Movie.RunTime
            };
            return movieDetails;
        }

        public async Task<IEnumerable<MovieCardResponseModel>> GetFavoriteMovies(int userId)
        {
            var user = await _userRepository.GetUserFavoriteById(userId);
            var movieCards = new List<MovieCardResponseModel>();
            foreach (var movie in user.Favorites)
            {
                movieCards.Add(new MovieCardResponseModel
                {
                    Id = movie.MovieId,
                    Title = movie.Movie.Title,
                    PosterUrl = movie.Movie.PosterUrl
                });
            }
            return movieCards;
        }

        public async Task<IEnumerable<MovieCardResponseModel>> GetPurchasedMovies(int userId)
        {
            var user = await _userRepository.GetUserPurchaseById(userId);
            var movieCards = new List<MovieCardResponseModel>();
            foreach (var movie in user.Purchases)
            {
                movieCards.Add(new MovieCardResponseModel
                {
                    Id = movie.MovieId,
                    Title = movie.Movie.Title,
                    PosterUrl = movie.Movie.PosterUrl
                });
            }
            return movieCards;
        }

        public async Task<UserResponseModel> GetUserById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            var userResponseModel = new UserResponseModel
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth
            };
            return userResponseModel;
        }


        public async Task<PurchaseResponseModel> PurchaseMovie(PurchaseRequestModel purchaseMovie)
        {
            var dbPurchase = await _purchaseRepository.GetExistsAsync(p => p.MovieId == purchaseMovie.MovieId && p.UserId == purchaseMovie.UserId);

            if (dbPurchase == true)
            {
                throw new ConflictException("You already bought this movie");
            }
            await _purchaseRepository.AddAsync(new Purchase
            {
                UserId = purchaseMovie.UserId,
                MovieId = purchaseMovie.MovieId

            });
            var purchase = new PurchaseResponseModel()
            {
                MovieId = purchaseMovie.MovieId,
                UserId = purchaseMovie.MovieId,
            };
            return purchase;
        }


        public async Task<MovieCardResponseModel> GetFavoriteMovieDetail(int id, int movieId)
        {
            var dbFavorite = await _favoriteRepository.GetFavoriteMovieDetails(id, movieId);
            var movieCardResponseModel = new MovieCardResponseModel
            {
                Id = dbFavorite.Id,
                Title = dbFavorite.Movie.Title,
                PosterUrl = dbFavorite.Movie.PosterUrl,
                Budget = (decimal)dbFavorite.Movie.Budget

            };
            return movieCardResponseModel;
        }

        public async Task<IEnumerable<Review>> GetReviews(int userId)
        {
            return await _reviewRepository.GetReviewsByUserId(userId);
        }


        public async Task<UserLoginResponseModel> Login(LoginRequestModel model)
        {
            var dbUser = await _userRepository.GetUserByEmail(model.Email);
            if(dbUser == null)
            {
                return null;
            }
            // get the hashed password and salt from database
            var hashedPassword = GetHashedPassword(model.Password, dbUser.Salt);

            if(hashedPassword == dbUser.HashedPassword)
            {
                // success
                var userLoginResponseModel = new UserLoginResponseModel
                {
                    Id = dbUser.Id,
                    FirstName = dbUser.FirstName,
                    LastName = dbUser.LastName,
                    Email = dbUser.Email
                };
                return userLoginResponseModel;
            }
            return null;
        }

        public async Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel model)
        {
            // make sure with the user entered email does not exists in database.
            var dbUser = await _userRepository.GetUserByEmail(model.Email);

            if (dbUser != null)
            {
                // user already has email
                throw new ConflictException("Email already exists");
            }

            // user does not exists in the database

            // generate a unique salt
            // hash password with salt

            var salt = GenerateSalt();
            var hashedPassword = GetHashedPassword(model.Password, salt);
            // save the salt and hashed password to the database

            // create User entity object
            var user = new User
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Salt = salt,
                HashedPassword = hashedPassword
            };

            var createdUser = await _userRepository.AddAsync(user);

            var userRegisterResponseModel = new UserRegisterResponseModel
            {
                Id = createdUser.Id,
                Email = createdUser.Email,
                FirstName = createdUser.FirstName,
                LastName = createdUser.LastName
            };

            return userRegisterResponseModel;
        }

        private string GenerateSalt()
        {
            byte[] randomBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            return Convert.ToBase64String(randomBytes);
        }

        private string GetHashedPassword(string password, string salt)
        {
            // Never ever create your own Hashing Algorithms
            // Always use Industry tried and tested Hashing Algorithms
            // Aarogon2 => Another popular hashed
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                                                     password: password,
                                                                     salt: Convert.FromBase64String(salt),
                                                                     prf: KeyDerivationPrf.HMACSHA512,
                                                                     iterationCount: 10000,
                                                                     numBytesRequested: 256 / 8));
            return hashed;
        }

        public async Task<UnFavoriteResponseModel> UnfavoriteMovie(UnFavoriteResponseModel model)
        {
            var exist = await _favoriteRepository.GetExistsAsync(f => f.Id == model.Id);
            if (!exist)
            {
                throw new Exception("This user did not favorite this movie");
            }
            var favorite = new Favorite { Id = model.Id, MovieId = model.MovieId, UserId = model.UserId };
            var unfavorite = await _favoriteRepository.DeleteAsync(favorite);
            return model;
        }

        public async Task<ReviewsRequestModel> WriteReview(ReviewsRequestModel model)
        {
            var exist = await _reviewRepository.GetExistsAsync(r => r.UserId == model.UserId && r.MovieId == model.MovieId);
            if (exist)
            {
                throw new Exception("This user has already written review for this movie");
            }
            var review = new Review
            {
                UserId = model.UserId,
                MovieId = model.MovieId,
                ReviewText = model.ReviewText,
                Rating = model.Rating
            };
            var createdReview = await _reviewRepository.AddAsync(review);
            return model;
        }

        public async Task<ReviewsRequestModel> UpdateReview(ReviewsRequestModel model)
        {
            var exist = await _reviewRepository.GetExistsAsync(r => r.UserId == model.UserId && r.MovieId == model.MovieId);
            if (!exist)
            {
                throw new Exception("This user has not written review for this movie");
            }
            var review = new Review
            {
                UserId = model.UserId,
                MovieId = model.MovieId,
                ReviewText = model.ReviewText,
                Rating = model.Rating
            };
            var createdReview = await _reviewRepository.UpdateAsync(review);
            return model;
        }

        public async Task<ReviewsRequestModel> DeleteReview(int userId, int movieId)
        {
            var exist = await _reviewRepository.GetExistsAsync(r => r.UserId == userId && r.MovieId == movieId);
            if (!exist)
            {
                throw new Exception("This user has not written review for this movie");
            }
            var review = new Review
            {
                UserId = userId,
                MovieId = movieId,
            };
            var createdReview = await _reviewRepository.DeleteAsync(review);
            var reviewResponse = new ReviewsRequestModel
            {
                UserId = createdReview.UserId,
                MovieId = createdReview.MovieId,
                ReviewText = createdReview.ReviewText,
                Rating = createdReview.Rating
            };
            return reviewResponse;
        }
    }
}
