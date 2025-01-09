using Microsoft.EntityFrameworkCore;
using Real_Estate_Business_API.Data;
using Real_Estate_Business_API.Interfaces;
using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Repository
{
    public class ReviewsRepository : IReviewsRepository
    {
        private readonly AppDbContext _context;

        public ReviewsRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Review>> GetAllAsync() => await _context.Reviews.Include(r => r.Client).ToListAsync();
    }
}
