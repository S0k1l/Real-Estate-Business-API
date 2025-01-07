using System.ComponentModel.DataAnnotations;

namespace Real_Estate_Business_API.Models
{
    public class HouseType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<House> Houses { get; set; }
    }
}
