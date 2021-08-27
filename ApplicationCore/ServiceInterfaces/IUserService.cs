using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel model);
        Task<UserLoginResponseModel> Login(LoginRequestModel model);
        Task<IEnumerable<MovieCardResponseModel>> GetPurchasedMovies(int userId);
        Task<IEnumerable<MovieCardResponseModel>> GetFavoriteMovies(int userId);
        Task <UserResponseModel> GetUserById(int id);
        Task<PurchaseResponseModel> PurchaseMovie(PurchaseRequestModel model);
        Task<FavoriteResponseModel> FavoriteMovie(FavoriteRequestModel model);
        Task<UnFavoriteResponseModel> UnfavoriteMovie(UnFavoriteResponseModel model);
        Task<MovieDetailsResponseModel> GetFavoriteMovieDetails(int userId, int movieId);
        Task<ReviewsRequestModel> WriteReview(ReviewsRequestModel model);
        Task<ReviewsRequestModel> UpdateReview(ReviewsRequestModel model);
        Task<ReviewsRequestModel> DeleteReview(int userId, int movieId);
        Task<IEnumerable<Review>> GetReviews(int userId);

    }
}
