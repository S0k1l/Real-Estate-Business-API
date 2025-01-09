using Real_Estate_Business_API.Models;

namespace Real_Estate_Business_API.Dto
{
    public class HouseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bedrooms { get; set; }
        public int Bathroom { get; set; }
        public decimal Area { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public decimal? PropertyTransferTax { get; set; }
        public decimal? LegalFees { get; set; }
        public decimal? HomeInspection { get; set; }
        public decimal? PropertyInsurance { get; set; }
        public decimal? MortgageFees { get; set; }
        public decimal? PropertyTaxes { get; set; }
        public decimal? HomeownersAssociationFee { get; set; }
        public decimal ListingPrice { get; set; }
        public List<string> FeaturesAndAmenities { get; set; }
        public List<string> HouseImgs { get; set; }
    }
}
