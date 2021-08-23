﻿using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;

        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }


        public async Task<CastResponseModel> GetCastDetails(int id)
        {
            var cast = await _castRepository.GetByIdAsync(id);
            var castDetailsModel = new CastResponseModel
            {
                Id = cast.Id,
                Name = cast.Name,
                Gender = cast.Gender,
                ProfilePath = cast.ProfilePath
            };

            castDetailsModel.Movies = new List<MovieDetailsResponseModel>();

            foreach (var movie in cast.MovieCasts)
            {
                castDetailsModel.Movies.Add(new MovieDetailsResponseModel
                {
                    Id = movie.MovieId,
                    Title = movie.Movie.Title,
                    PosterUrl = movie.Movie.PosterUrl,
                    ReleaseDate = movie.Movie.ReleaseDate.Value
                });
            }
            return castDetailsModel;
        }

        public async Task<CastResponseModel> GetCastById(int id)
        {
            var x = 0;
            x += 1;
            var cast = await _castRepository.GetByIdAsync(id);

            var castDetails = new CastResponseModel()
            {
                Id = cast.Id,
                Name = cast.
                Gender = cast.Gender,
                ProfilePath = cast.ProfilePath,
            };

            return castDetails;
        }
    }
}
