﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Resort_Web.Data;

#nullable disable

namespace Resort_Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231012182052_AddForeignKeyToVillaTable")]
    partial class AddForeignKeyToVillaTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Resort_Web.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Occupancy")
                        .HasColumnType("integer");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<int>("SqFt")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedAt = new DateTime(2023, 10, 12, 18, 20, 52, 444, DateTimeKind.Utc).AddTicks(3021),
                            Details = "Etiam auctor pellentesque metus sit amet accumsan. Proin laoreet viverra nibh, eget eleifend dui condimentum pulvinar. Duis auctor in ipsum ut rutrum. Aliquam posuere sollicitudin quam. In in lobortis felis. Fusce ultricies, eros nec vestibulum pulvinar, ex massa interdum nunc, at pretium ipsum justo ac ex. Suspendisse ut luctus lectus. Proin congue sodales porta. Proin eleifend semper neque eu iaculis. Donec feugiat risus enim, vitae consectetur mauris porta id. Donec euismod, massa non porttitor tincidunt, diam dolor dignissim nisl",
                            ImageUrl = "",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            SqFt = 580,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedAt = new DateTime(2023, 10, 12, 18, 20, 52, 444, DateTimeKind.Utc).AddTicks(3024),
                            Details = "Sed mollis odio in justo volutpat semper. Etiam eget interdum ipsum, id placerat dui. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus",
                            ImageUrl = "",
                            Name = "Diamond Villa",
                            Occupancy = 7,
                            Rate = 170.0,
                            SqFt = 480,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedAt = new DateTime(2023, 10, 12, 18, 20, 52, 444, DateTimeKind.Utc).AddTicks(3026),
                            Details = "Donec est lacus, pharetra sagittis eleifend ac, sodales sit amet tortor. Aliquam massa odio, ullamcorper sit amet tristique in, facilisis at libero. Aenean in magna mi. ",
                            ImageUrl = "",
                            Name = "Safire Royal Villa",
                            Occupancy = 9,
                            Rate = 400.0,
                            SqFt = 660,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Resort_Web.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("VillaId")
                        .HasColumnType("integer");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("Resort_Web.Models.VillaNumber", b =>
                {
                    b.HasOne("Resort_Web.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
