using Microsoft.EntityFrameworkCore;
using Real_Estate_Business_API.Data;
using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Interfaces;
using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Repository
{
    public class ValuedClientsRepository : IValuedClientsRepository
    {
        private readonly AppDbContext _context;

        public ValuedClientsRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<PagedResponse<ValuedClientsDto>> GetAllAsync(int pageIndex, int pageSize)
        {
           var valuedClient = await _context.ValuedClients
                .Include(vc => vc.Category)
                .Select(vc => new ValuedClientsDto
                {
                    Company = vc.Company,
                    Domain = vc.Domain,
                    Year = vc.Year,
                    Category = vc.Category.Type,
                    Comment = vc.Comment,
                })
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var count = await _context.ValuedClients.CountAsync();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);

            return new PagedResponse<ValuedClientsDto>(valuedClient, pageIndex, totalPages);
        }
        
    }
}
