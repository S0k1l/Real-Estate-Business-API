using System.ComponentModel.DataAnnotations;

namespace Real_Estate_Business_API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<ValuedClient> ValuedClients { get; set; }
    }
}
