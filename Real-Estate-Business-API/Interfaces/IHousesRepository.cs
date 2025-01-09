using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Interfaces
{
    public interface IHousesRepository
    {
        Task<PagedResponse<HousesAdvertsDto>> GetAllAdvertsAsync(int pageIndex, int pageSize, SearchRequest searchRequest);
        Task<PagedResponse<HousesDetailsDto>> GetAllDetailsAsync(int pageIndex, int pageSize);
        Task<List<string>> GetLocations();
        Task<House> GetHouseAsync(int Id);        
    }
}
