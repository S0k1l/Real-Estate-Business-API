using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_Estate_Business_API.Models
{
    public class FeaturesAndAmenities
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }
    }
}
