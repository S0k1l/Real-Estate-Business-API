using Microsoft.AspNetCore.Mvc;
using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Real_Estate_Business_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsCotroller : ControllerBase
    {
        private readonly IReviewsRepository _reviewsRepository;

        public ReviewsCotroller(IReviewsRepository reviewsRepository)
        {
            _reviewsRepository = reviewsRepository;
        }
        // GET: api/<ReviewsCotroller>
        [HttpGet]
        public async Task<IActionResult> Get(int pageIndex, int pageSize)
        {
            var reviews = await _reviewsRepository.GetAllAsync(pageIndex, pageSize);

            if (reviews == null) { return BadRequest(ModelState); }

            return Ok(reviews);
        }
    }
}
