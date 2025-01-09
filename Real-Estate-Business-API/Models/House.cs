using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_Estate_Business_API.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bedrooms { get; set; }
        public int Bathroom { get; set; }
        public decimal Area { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Advert { get; set; }
        public string Quote { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int HouseTypeId { get; set; }
        public HouseType HouseType { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public ICollection<FeaturesAndAmenities> FeaturesAndAmenities { get; set; }
        public ICollection<HouseImg> HouseImgs { get; set; }

    }
}
