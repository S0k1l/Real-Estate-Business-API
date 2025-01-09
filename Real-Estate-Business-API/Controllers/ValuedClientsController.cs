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
        public async Task<IActionResult> Get(int pageIndex, int pageSize)
        {
            var valuedClients = await _valuedClientsRepository.GetAllAsync(pageIndex, pageSize);

            if (valuedClients == null) { return BadRequest(ModelState); }

            return Ok(valuedClients);
        }
    }
}
