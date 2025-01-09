using Microsoft.EntityFrameworkCore;
using Real_Estate_Business_API.Models;
using System.Drawing;

namespace Real_Estate_Business_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<FeaturesAndAmenities> FeaturesAndAmenities { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<HouseImg> HouseImgs { get; set; }
        public DbSet<HouseType> HouseTypes { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ValuedClient> ValuedClients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            //Set Decimal Precision
            modelBuilder.Entity<Pricing>(entity =>
            {
                entity.Property(e => e.PropertyTransferTax).HasColumnType("decimal(10,2)");
                entity.Property(e => e.LegalFees).HasColumnType("decimal(10,2)");
                entity.Property(e => e.HomeInspection).HasColumnType("decimal(10,2)");
                entity.Property(e => e.PropertyInsurance).HasColumnType("decimal(10,2)");
                entity.Property(e => e.MortgageFees).HasColumnType("decimal(10,2)");
                entity.Property(e => e.PropertyTaxes).HasColumnType("decimal(10,2)");
                entity.Property(e => e.HomeownersAssociationFee).HasColumnType("decimal(10,2)");
                entity.Property(e => e.ListingPrice).HasColumnType("decimal(12,2)");
            });

            modelBuilder.Entity<House>()
                        .Property(e => e.Area)
                        .HasColumnType("decimal(10,2)");

            //One-to-One relationships
            modelBuilder.Entity<Review>()
                   .HasOne(r => r.Client)
                   .WithOne(c => c.Review)
                   .HasForeignKey<Review>(r => r.ClientId);

            modelBuilder.Entity<Pricing>()
                       .HasOne(p => p.House)
                       .WithOne(h => h.Pricing)
                       .HasForeignKey<Pricing>(p => p.HouseId); 
        }
    }
}
