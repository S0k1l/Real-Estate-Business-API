namespace Real_Estate_Business_API.Dto
{
    public class SearchRequest
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int? PropertyTypeId { get; set; }
        public decimal? PricingRange { get; set; }
        public decimal? PropertySize { get; set; }

    }
}
