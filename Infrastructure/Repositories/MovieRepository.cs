using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<IEnumerable<Movie>> Get30HighestRevenueMovies()
        {
            //get 30 movies from movie table order by revenue
            //select top 30 from movies order by revenue
            //ToList(), Count() or we can loop through
            //I/O bound oepration
            //EF has methods that have both async and non-async ones
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();
            return movies;
        }

        public override async Task<Movie> GetByIdAsync(int id)
        {
            // movie table, then genres, then casts and rating
            // Include() ThenInclude()
            var movie = await _dbContext.Movies.Include(m => m.MovieCasts).ThenInclude(m => m.Cast).Include(m => m.Genres).FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                throw new Exception($"No Movie Found for the id{id}");
            }

            var movieRating = await _dbContext.Reviews.Where(m => m.MovieId == id).DefaultIfEmpty().AverageAsync(r => r == null ? 0 : r.Rating);

            movie.Rating = movieRating;
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetTopRatedMovies()
        {
            var topRatedMovies = await _dbContext.Reviews.Include(r => r.Movie)
                    .GroupBy(r => new
                    {
                        Id = r.MovieId,
                        r.Movie.PosterUrl,
                        r.Movie.Title,
                    })
                    .OrderByDescending(g => g.Average(r => r.Rating))
                    .Select(m => new Movie
                    {
                        Id = m.Key.Id,
                        PosterUrl = m.Key.PosterUrl,
                        Title = m.Key.Title,
                        Rating = m.Average(x => x.Rating)
                    })
                    .Take(30)
                    .ToListAsync();

            return topRatedMovies;
        }

        public async Task<IEnumerable<Review>> GetReviewsByMovieId(int id)
        {
            var movie = await _dbContext.Reviews.Where(r => r.MovieId == id).ToListAsync();

            return movie;
        }

    }
}
