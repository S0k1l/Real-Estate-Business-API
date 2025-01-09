using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Interfaces
{
    public interface IValuedClientsRepository
    {
        Task<ICollection<ValuedClient>> GetAllsAsync();
    }
}
