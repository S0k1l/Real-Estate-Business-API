using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_Estate_Business_API.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ImgUrl { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
