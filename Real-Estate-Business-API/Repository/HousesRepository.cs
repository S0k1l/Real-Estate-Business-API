using FuzzySharp;
using Microsoft.EntityFrameworkCore;
using Real_Estate_Business_API.Data;
using Real_Estate_Business_API.Dto;
using Real_Estate_Business_API.Interfaces;
using Real_Estate_Business_API.Models;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Real_Estate_Business_API.Repository
{
    public class HousesRepository : IHousesRepository
    {
        private readonly AppDbContext _context;

        public HousesRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResponse<HousesAdvertsDto>> GetAllAdvertsAsync(int pageIndex, int pageSize, SearchRequest searchRequest)
        {
            var query = _context.Houses
                .Include(h => h.Pricing)
                .Include(h => h.HouseImgs)
                .AsQueryable();

            if (searchRequest.PropertyTypeId.HasValue)
            {
                query = query.Where(h => h.HouseType.Id == searchRequest.PropertyTypeId);
            }

            if (searchRequest.PropertySize.HasValue)
            {
                query = query.Where(h => h.Area <= searchRequest.PropertySize);
            }

            if (searchRequest.PricingRange.HasValue)
            {
                query = query.Where(h => h.Pricing.ListingPrice <= searchRequest.PricingRange);
            }

            if (!string.IsNullOrEmpty(searchRequest.Location))
            {
                var locationParts = searchRequest.Location.Split(',');
                if (locationParts.Length == 3)
                {
                    query = query.Where(h => h.Country == locationParts[0].Trim() && h.State == locationParts[1].Trim() && h.City == locationParts[2].Trim());
                }
            }

            var houses = await query.ToListAsync();

            if (!string.IsNullOrEmpty(searchRequest.Name))
            {
                var bestMatches = houses.Select(record => new
                {
                    Record = record,
                    Score = Fuzz.TokenSetRatio(searchRequest.Name, record.Name)
                })
                .OrderByDescending(result => result.Score)
                .ToList();

                houses = bestMatches.Select(bm => bm.Record).ToList();
            }

            var count = houses.Count();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);

            var housesPaginated = houses
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(h => new HousesAdvertsDto
                {
                    Id = h.Id,
                    Name = h.Name,
                    Advert = h.Advert,
                    Quote = h.Quote,
                    Pricing = h.Pricing.ListingPrice,
                    HouseImg = h.HouseImgs.FirstOrDefault().Url
                })
                .ToList();

            return new PagedResponse<HousesAdvertsDto>(housesPaginated, pageIndex, totalPages);
        }

        public async Task<PagedResponse<HousesDetailsDto>> GetAllDetailsAsync(int pageIndex, int pageSize)
        {

            var houses = await _context.Houses
                 .Include(h => h.Pricing)
                 .Include(h => h.HouseImgs)
                 .Select(h => new HousesDetailsDto
                 {
                     Id = h.Id,
                     Name = h.Name,
                     Bedrooms = h.Bedrooms,
                     Bathroom = h.Bathroom,
                     Area = h.Area,
                     Details = h.Details,
                     HouseType = h.HouseType.Type,
                     Pricing = h.Pricing.ListingPrice,
                     HouseImg = h.HouseImgs.FirstOrDefault().Url
                 })
                 .Skip((pageIndex - 1) * pageSize)
                 .Take(pageSize)
                 .ToListAsync();

            var count = await _context.Reviews.CountAsync();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);

            return new PagedResponse<HousesDetailsDto>(houses, pageIndex, totalPages);
        }

        public async Task<House> GetHouseAsync(int Id) => 
            await _context.Houses
                .Where(h => h.Id == Id)
                .Include(h => h.HouseImgs)
                .Include(h => h.Pricing)
                .Include(h => h.FeaturesAndAmenities)
                .FirstOrDefaultAsync();

        public async Task<List<string>> GetLocations() =>  
            await _context.Houses.Select(h => $"{h.Country}, {h.State}, {h.City}").Distinct().ToListAsync();
        
    }
}
