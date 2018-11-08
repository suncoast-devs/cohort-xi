﻿// <auto-generated />
using System;
using CoffeeShipAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CoffeeShipAPI.Migrations
{
    [DbContext(typeof(CoffeeShopFinderContext))]
    partial class CoffeeShopFinderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CoffeeShipAPI.Models.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<int>("BrandColor");

                    b.Property<bool>("IsLocal");

                    b.HasKey("Id");

                    b.ToTable("Franchises");

                    b.HasData(
                        new { Id = -1, Brand = "StarBucks", BrandColor = 3, IsLocal = false },
                        new { Id = -2, Brand = "Kahwa", BrandColor = 2, IsLocal = true },
                        new { Id = -3, Brand = "Bikery", BrandColor = 7, IsLocal = true }
                    );
                });

            modelBuilder.Entity("CoffeeShipAPI.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<int>("FranchiseId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("PriceRange");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("FranchiseId");

                    b.ToTable("Locations");

                    b.HasData(
                        new { Id = -1, Address = "123 Fake St", City = "Tampa", FranchiseId = -1, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d3/Starbucks_Corporation_Logo_2011.svg/1200px-Starbucks_Corporation_Logo_2011.svg.png", PhoneNumber = "8138675309", PriceRange = 1, State = "FL", Zip = "12345" },
                        new { Id = -2, Address = "456 Over There Ave", City = "Tampa", FranchiseId = -1, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d3/Starbucks_Corporation_Logo_2011.svg/1200px-Starbucks_Corporation_Logo_2011.svg.png", PhoneNumber = "5555555555", PriceRange = 1, State = "FL", Zip = "12345" },
                        new { Id = -3, Address = "789 Nope Blvd", City = "St Pete", FranchiseId = -1, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d3/Starbucks_Corporation_Logo_2011.svg/1200px-Starbucks_Corporation_Logo_2011.svg.png", PhoneNumber = "4563452341", PriceRange = 1, State = "FL", Zip = "34135" },
                        new { Id = -4, Address = "123 Fake St", City = "Tampa", FranchiseId = -2, ImageUrl = "https://2015.tampa.wordcamp.org/files/2015/09/KahwaFinal_noBean-1000x991.jpg", PhoneNumber = "8138675309", PriceRange = 0, State = "FL", Zip = "33645" },
                        new { Id = -5, Address = "123 Fake St", City = "Tampa", FranchiseId = -2, ImageUrl = "https://2015.tampa.wordcamp.org/files/2015/09/KahwaFinal_noBean-1000x991.jpg", PhoneNumber = "8138675309", PriceRange = 0, State = "FL", Zip = "12345" },
                        new { Id = -6, Address = "123 Fake St", City = "St Pete", FranchiseId = -3, ImageUrl = "https://s3-media2.fl.yelpcdn.com/bphoto/_-S7SNvGJFEPNMrRvxAgPQ/348s.jpg", PhoneNumber = "8138675309", PriceRange = 2, State = "FL", Zip = "33645" }
                    );
                });

            modelBuilder.Entity("CoffeeShipAPI.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationId");

                    b.Property<int>("Score");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("CoffeeShipAPI.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("LocationId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("CoffeeShipAPI.Models.Location", b =>
                {
                    b.HasOne("CoffeeShipAPI.Models.Franchise", "Franchise")
                        .WithMany("Locations")
                        .HasForeignKey("FranchiseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoffeeShipAPI.Models.Rating", b =>
                {
                    b.HasOne("CoffeeShipAPI.Models.Location", "Location")
                        .WithMany("Ratings")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoffeeShipAPI.Models.Review", b =>
                {
                    b.HasOne("CoffeeShipAPI.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
