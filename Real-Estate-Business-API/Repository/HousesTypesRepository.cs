using Microsoft.EntityFrameworkCore;
using Real_Estate_Business_API.Data;
using Real_Estate_Business_API.Interfaces;
using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Repository
{
    public class HousesTypesRepository : IHousesTypesRepository
    {
        private readonly AppDbContext _context;

        public HousesTypesRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<HouseType>> GetAllAsync() => await _context.HouseTypes.ToListAsync();
    }
}
