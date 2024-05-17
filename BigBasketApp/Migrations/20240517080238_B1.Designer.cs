﻿// <auto-generated />
using BigBasketApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BigBasketApp.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20240517080238_B1")]
    partial class B1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BigBasketApp.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 101,
                            Name = "Sunanda",
                            Password = "123"
                        },
                        new
                        {
                            UserId = 102,
                            Name = "Siva",
                            Password = "1234"
                        },
                        new
                        {
                            UserId = 103,
                            Name = "Charan",
                            Password = "12345"
                        },
                        new
                        {
                            UserId = 104,
                            Name = "Syamala",
                            Password = "1236"
                        },
                        new
                        {
                            UserId = 105,
                            Name = "Bhaskar",
                            Password = "1237"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
