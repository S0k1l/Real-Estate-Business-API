using Microsoft.AspNetCore.Mvc;
using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Interfaces;
using Real_Estate_Business_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Real_Estate_Business_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly IHousesRepository _housesRepository;

        public HousesController(IHousesRepository housesRepository)
        {
            _housesRepository = housesRepository;
        }
        // GET: api/<HousesController>/Details
        [HttpGet("Details")]
        public async Task<IActionResult> GetDetails(int pageIndex, int pageSize)
        {
            var houses = await _housesRepository.GetAllDetailsAsync(pageIndex, pageSize);

            if (houses == null) { return NotFound(); }

            return Ok(houses);
        }

        // GET: api/<HousesController>/Adverts
        [HttpPost("Adverts")]
        public async Task<IActionResult> GetAdverts(int pageIndex, int pageSize, SearchRequest searchRequest)
        {
            var houses = await _housesRepository.GetAllAdvertsAsync(pageIndex, pageSize, searchRequest);

           if (houses == null) { return NotFound(); }

            return Ok(houses);
        }

        // GET: api/<HousesController>/Adverts
        [HttpGet("Locations")]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _housesRepository.GetLocations();
            return Ok(new { locations });
        }

        // GET api/<HousesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var house = await _housesRepository.GetHouseAsync(id);

            if (house == null) { return NotFound(); };

            var houseDto = new HouseDto
            {
                Id = house.Id,
                Name = house.Name,
                Bedrooms = house.Bedrooms,
                Bathroom = house.Bathroom,
                Area = house.Area,
                Description = house.Description,
                Country = house.Country,
                State = house.State,
                City = house.City,
                PropertyTransferTax = house.Pricing.PropertyTransferTax,
                LegalFees = house.Pricing.LegalFees,
                HomeInspection = house.Pricing.HomeInspection,
                PropertyInsurance = house.Pricing.PropertyInsurance,
                MortgageFees = house.Pricing.MortgageFees,
                PropertyTaxes = house.Pricing.PropertyTaxes,
                HomeownersAssociationFee = house.Pricing.HomeownersAssociationFee,
                ListingPrice = house.Pricing.ListingPrice,
                FeaturesAndAmenities =house.FeaturesAndAmenities.Select(faa => faa.Text).ToList(),
                HouseImgs = house.HouseImgs.Select(hi => hi.Url).ToList(),
            };

            return Ok(houseDto);
        }
    }
}
