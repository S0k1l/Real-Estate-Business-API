using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_Estate_Business_API.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
