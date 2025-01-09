using Microsoft.AspNetCore.Mvc;
using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Real_Estate_Business_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuedClientsController : ControllerBase
    {
        private readonly IValuedClientsRepository _valuedClientsRepository;

        public ValuedClientsController(IValuedClientsRepository valuedClientsRepository)
        {
            _valuedClientsRepository = valuedClientsRepository;
        }

        // GET: api/<ValuedClientsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var valuedClients = await _valuedClientsRepository.GetAllsAsync();

            if (valuedClients == null) { return BadRequest(ModelState); }

            var valuedClientsDto = valuedClients.Select(vc => new ValuedClientsDto
            {
                Company = vc.Company,
                Domain = vc.Domain,
                Year = vc.Year,
                Category = vc.Category.Type
            });

            return Ok(valuedClientsDto);
        }
    }
}
