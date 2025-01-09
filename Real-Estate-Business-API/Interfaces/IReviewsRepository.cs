using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Interfaces
{
    public interface IReviewsRepository
    {
        Task<PagedResponse<ReviewsDto>> GetAllAsync(int pageIndex, int pageSize);
    }
}
