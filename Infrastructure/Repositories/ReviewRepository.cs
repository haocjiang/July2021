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
    public class ReviewRepository : EfRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }


        public async Task<List<Review>> GetReviewsByUserId(int userid)
        {
            var reviews = await _dbContext.Reviews.Include(r => r.UserId == userid).ToListAsync();
            return reviews;
        }
    }
}
