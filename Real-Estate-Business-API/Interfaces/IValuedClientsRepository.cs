using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Interfaces
{
    public interface IValuedClientsRepository
    {
        Task<PagedResponse<ValuedClientsDto>> GetAllAsync(int pageIndex, int pageSize);
    }
}
