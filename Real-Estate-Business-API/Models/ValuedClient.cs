using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_Estate_Business_API.Models
{
    public class ValuedClient
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Domain { get; set; }
        public string Year { get; set; }
        public string Comment { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
