﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zoo.DbContexts;

#nullable disable

namespace Zoo.Migrations
{
    [DbContext(typeof(AnimalContext))]
    partial class AnimalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Zoo.Model.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityOrigin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityOrigin = "Hungary",
                            Name = "Janos",
                            Weight = 150
                        },
                        new
                        {
                            Id = 2,
                            CityOrigin = "Serbia",
                            Name = "Milojko",
                            Weight = 89
                        },
                        new
                        {
                            Id = 3,
                            CityOrigin = "Germany",
                            Name = "Klaus",
                            Weight = 150
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
