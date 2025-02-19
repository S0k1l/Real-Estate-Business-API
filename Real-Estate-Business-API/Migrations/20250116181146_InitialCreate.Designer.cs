﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Real_Estate_Business_API.Data;

#nullable disable

namespace Real_Estate_Business_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250116181146_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Real_Estate_Business_API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReviewId")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.FeaturesAndAmenities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("HouseId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("FeaturesAndAmenities");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Advert")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Bathroom")
                        .HasColumnType("integer");

                    b.Property<int>("Bedrooms")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HouseTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PricingId")
                        .HasColumnType("integer");

                    b.Property<string>("Quote")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HouseTypeId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.HouseImg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("HouseId")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("HouseImgs");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.HouseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HouseTypes");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.Pricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("HomeInspection")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("HomeownersAssociationFee")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("HouseId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("LegalFees")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ListingPrice")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("MortgageFees")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("PropertyInsurance")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("PropertyTaxes")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("PropertyTransferTax")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("HouseId")
                        .IsUnique();

                    b.ToTable("Pricings");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Rate")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.ValuedClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ValuedClients");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.FeaturesAndAmenities", b =>
                {
                    b.HasOne("Real_Estate_Business_API.Models.House", "House")
                        .WithMany("FeaturesAndAmenities")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.House", b =>
                {
                    b.HasOne("Real_Estate_Business_API.Models.HouseType", "HouseType")
                        .WithMany("Houses")
                        .HasForeignKey("HouseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HouseType");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.HouseImg", b =>
                {
                    b.HasOne("Real_Estate_Business_API.Models.House", "House")
                        .WithMany("HouseImgs")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.Pricing", b =>
                {
                    b.HasOne("Real_Estate_Business_API.Models.House", "House")
                        .WithOne("Pricing")
                        .HasForeignKey("Real_Estate_Business_API.Models.Pricing", "HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.Review", b =>
                {
                    b.HasOne("Real_Estate_Business_API.Models.Client", "Client")
                        .WithOne("Review")
                        .HasForeignKey("Real_Estate_Business_API.Models.Review", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.ValuedClient", b =>
                {
                    b.HasOne("Real_Estate_Business_API.Models.Category", "Category")
                        .WithMany("ValuedClients")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.Category", b =>
                {
                    b.Navigation("ValuedClients");
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.Client", b =>
                {
                    b.Navigation("Review")
                        .IsRequired();
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.House", b =>
                {
                    b.Navigation("FeaturesAndAmenities");

                    b.Navigation("HouseImgs");

                    b.Navigation("Pricing")
                        .IsRequired();
                });

            modelBuilder.Entity("Real_Estate_Business_API.Models.HouseType", b =>
                {
                    b.Navigation("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
