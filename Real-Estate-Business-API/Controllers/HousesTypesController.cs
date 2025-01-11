using Microsoft.AspNetCore.Mvc;
using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Real_Estate_Business_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesTypesController : ControllerBase
    {
        private readonly IHousesTypesRepository _typesRepository;

        public HousesTypesController(IHousesTypesRepository typesRepository)
        {
            _typesRepository = typesRepository;
        }
        // GET: api/<TypesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var houseTypes = await _typesRepository.GetAllAsync();

            if (houseTypes == null) { NotFound(); }

            var houseTypesDto = houseTypes.Select(t => new HousesTypesDto
            {
                Id = t.Id,
                Type = t.Type,
            }).ToList();

            return Ok(houseTypesDto);
        }
    }
}
