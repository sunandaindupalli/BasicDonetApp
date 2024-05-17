﻿// <auto-generated />
using System;
using BigBasketApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BigBasketApp.Migrations.Items
{
    [DbContext(typeof(ItemsContext))]
    [Migration("20240517092056_B2")]
    partial class B2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BigBasketApp.Models.BasketItems", b =>
                {
                    b.Property<int?>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("ItemId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("double precision");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1001,
                            Category = "Vegitable",
                            Description = "Hybrid Tomato's",
                            Name = "Tomato",
                            Price = 20.0,
                            Quantity = "500g"
                        },
                        new
                        {
                            ItemId = 1002,
                            Category = "Vegitable",
                            Description = "Organically grown",
                            Name = "Onions",
                            Price = 25.0,
                            Quantity = "1kg"
                        },
                        new
                        {
                            ItemId = 1003,
                            Category = "Vegitable",
                            Description = "Fresh Coriander",
                            Name = "Coriander Leaves",
                            Price = 10.0,
                            Quantity = "200g"
                        },
                        new
                        {
                            ItemId = 1004,
                            Category = "Vegitable",
                            Description = "Hybrid Carrots",
                            Name = "Carrot",
                            Price = 50.0,
                            Quantity = "500g"
                        },
                        new
                        {
                            ItemId = 1005,
                            Category = "Vegitable",
                            Description = "Potato's Loose",
                            Name = "Potato",
                            Price = 30.0,
                            Quantity = "1kg"
                        },
                        new
                        {
                            ItemId = 1006,
                            Category = "Fruits",
                            Description = "Organic Apples",
                            Name = "Apples",
                            Price = 200.0,
                            Quantity = "1kg"
                        },
                        new
                        {
                            ItemId = 1007,
                            Category = "Fruits",
                            Description = "Hybrid Oranges's",
                            Name = "Oranges",
                            Price = 120.0,
                            Quantity = "500g"
                        },
                        new
                        {
                            ItemId = 1008,
                            Category = "Fruits",
                            Description = "Local",
                            Name = "Banana",
                            Price = 50.0,
                            Quantity = "1kg"
                        },
                        new
                        {
                            ItemId = 1009,
                            Category = "Vegitable",
                            Description = "Green Chillies",
                            Name = "Chillies",
                            Price = 10.0,
                            Quantity = "100g"
                        },
                        new
                        {
                            ItemId = 1010,
                            Category = "Vegitable",
                            Description = "Curry leaves loose",
                            Name = "Curry leaves",
                            Price = 5.0,
                            Quantity = "100g"
                        },
                        new
                        {
                            ItemId = 1011,
                            Category = "Fruits",
                            Description = "Organic Mango's",
                            Name = "Mango",
                            Price = 200.0,
                            Quantity = "1.5kg"
                        },
                        new
                        {
                            ItemId = 1012,
                            Category = "Vegitable",
                            Description = "Lemons",
                            Name = "Lemon",
                            Price = 8.0,
                            Quantity = "1pc"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}