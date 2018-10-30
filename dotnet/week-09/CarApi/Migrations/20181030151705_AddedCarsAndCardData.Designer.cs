﻿// <auto-generated />
using CarApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CarApi.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20181030151705_AddedCarsAndCardData")]
    partial class AddedCarsAndCardData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CarApi.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<double>("Price");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Car");

                    b.HasData(
                        new { Id = 1, Color = "Blue", Make = "Benz", Model = "Mercedes", Price = 50000.0, Year = 2019 },
                        new { Id = 2, Color = "Red", Make = "BMW", Model = "M3", Price = 17000.0, Year = 1999 },
                        new { Id = 3, Color = "Green", Make = "Moz", Model = "Turbo", Price = 35000.0, Year = 1988 },
                        new { Id = 4, Color = "Shiny", Make = "Toyota", Model = "Camry", Price = 75000.0, Year = 1967 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}