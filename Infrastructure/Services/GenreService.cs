using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GenreService : IGenreService
    {
        private readonly IAsyncRepository<Genre> _genreRepository;

        public GenreService(IAsyncRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public Task<IEnumerable<GenreResponseModel>> GetGenreDetails()
        {
            
        }
    }
    
}
