﻿using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieShopAPI.Controllers
{
    // Attribute Routing
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;
        public MoviesController(IMovieService movieService, IGenreService genreService)
        {
            _movieService = movieService;
            _genreService = genreService;
        }

        // api/movies/toprevenue
        [Route("toprevenue")]
        [HttpGet]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _movieService.GetTopRevenueMovies();
            // along with data you also need to return HTTP status code
            if (!movies.Any())
            {
                return NotFound("No Movies Found");
            }
            return Ok(movies);
            // Serialization => object to another type of obejct => C# to JSON
            // C# to XML using XMLSerilizer
            // DeSerialization => JSON to C#
            // .Net Core 3.1 or less = JSON.NET => 3rd party library, included
            // System.Text.JSON =>
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await _movieService.GetAllMovies();
            if (!movies.Any())
            {
                return NotFound("No Movie Found");
            }
            return Ok(movies);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetMovieDetailsById(int id)
        {
            var movieDetail = await _movieService.GetMovieDetails(id);
            if (movieDetail == null)
            {
                return NotFound($"No Movie Found For Id = {id}");
            }
            return Ok(movieDetail);
        }

        [HttpGet]
        [Route("toprated")]
        public async Task<IActionResult> GetTopRatedMovies()
        {
            var movieCards = await _movieService.GetTopRatedMovies();
            if (movieCards == null)
            {
                return NotFound("No Movie Found");
            }
            return Ok(movieCards);
        }

        [HttpGet]
        [Route("genre/{genreId:int}")]
        public async Task<IActionResult> GetMoviesByGenre(int genreId)
        {
            var movieCards = await _genreService.GetAllMovies(genreId);
            if (movieCards == null)
            {
                return NotFound($"No Movie Found For Genre Id = {genreId}");
            }
            return Ok(movieCards);
        }

        [HttpGet]
        [Route("{id:int}/reviews")]
        public async Task<IActionResult> GetReviewsByMovieId(int id)
        {
            var movieReviews = await _movieService.GetMovieReviews(id);
            if (movieReviews == null)
            {
                return NotFound($"No Review Found For Movie Id = {id}");
            }
            return Ok(movieReviews);
        }

    }
}
