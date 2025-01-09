using Microsoft.EntityFrameworkCore;
using Real_Estate_Business_API.Data;
using Real_Estate_Business_API.Interfaces;

namespace Real_Estate_Business_API.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly AppDbContext _context;

        public CategoriesRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<string>> GetAllAsync() => 
            await _context.Categories.Select(c => c.Type).ToListAsync();
    }
}
