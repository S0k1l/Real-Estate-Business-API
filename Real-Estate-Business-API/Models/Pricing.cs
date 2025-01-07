using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;

namespace Real_Estate_Business_API.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public decimal PropertyTransferTax { get; set; }
        public decimal LegalFees { get; set; }
        public decimal HomeInspection { get; set; }
        public decimal PropertyInsurance { get; set; }
        public decimal MortgageFees { get; set; }
        public decimal PropertyTaxes { get; set; }
        public decimal HomeownersAssociationFee { get; set; }
        public decimal ListingPrice { get; set; }
        public decimal DownPayment { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }
    }
}
