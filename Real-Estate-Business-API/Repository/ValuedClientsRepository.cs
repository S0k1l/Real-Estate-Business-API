using Microsoft.EntityFrameworkCore;
using Real_Estate_Business_API.Data;
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
        public async Task<ICollection<ValuedClient>> GetAllsAsync() => 
            await _context.ValuedClients.Include(vc => vc.Category).ToListAsync();
        
    }
}
