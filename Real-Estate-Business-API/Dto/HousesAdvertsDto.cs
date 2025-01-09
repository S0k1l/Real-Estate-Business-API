using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Dto
{
    public class HousesAdvertsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Advert { get; set; }
        public string Quote { get; set; }
        public decimal Pricing { get; set; }
        public string HouseImg { get; set; }
    }
}
