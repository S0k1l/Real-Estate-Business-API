using Microsoft.EntityFrameworkCore;
using Real_Estate_Business_API.Data;
using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Interfaces;

namespace Real_Estate_Business_API.Repository
{
    public class ReviewsRepository : IReviewsRepository
    {
        private readonly AppDbContext _context;

        public ReviewsRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<PagedResponse<ReviewsDto>> GetAllAsync(int pageIndex, int pageSize)
        {
           var reviews = await _context.Reviews
                .Include(r => r.Client)
                .Select(r => new ReviewsDto
                {
                    Heading = r.Heading,
                    Comment = r.Comment,
                    Rate = r.Rate,
                    UserFullName = r.Client.FullName,
                    UserCountry = r.Client.Country,
                    UserState = r.Client.State,
                    UserImgUrl = r.Client.ImgUrl,
                })
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var count = await _context.Reviews.CountAsync();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);

            return new PagedResponse<ReviewsDto>(reviews, pageIndex, totalPages);
        }
    }
}
