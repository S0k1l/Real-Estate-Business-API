using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Dto
{
    public class HousesDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bedrooms { get; set; }
        public int Bathroom { get; set; }
        public decimal Area { get; set; }
        public string Details { get; set; }
        public string HouseType { get; set; }
        public decimal Pricing { get; set; }
        public string HouseImg { get; set; }
    }
}
