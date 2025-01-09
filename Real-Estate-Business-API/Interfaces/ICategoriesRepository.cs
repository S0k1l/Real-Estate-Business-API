namespace Real_Estate_Business_API.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<string>> GetAllAsync();
    }
}
