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
        public async Task<IActionResult> Get()
        {
            var reviews = await _reviewsRepository.GetAllAsync();

            if (reviews == null) { return BadRequest(ModelState); }

            var reviewsDto = reviews.Select(r => new ReviewsDto
            {
                Heading = r.Heading,
                Comment = r.Comment,
                Rate = r.Rate,
                UserFullName = r.Client.FullName,
                UserCountry = r.Client.Country,
                UserState = r.Client.State,
                UserImgUrl = r.Client.ImgUrl,
            });

            return Ok(reviewsDto);
        }
    }
}
