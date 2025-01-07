using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_Estate_Business_API.Models
{
    public class HouseImg
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }
    }
}
