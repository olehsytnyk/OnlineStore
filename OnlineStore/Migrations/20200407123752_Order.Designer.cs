﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.Data;

namespace OnlineStore.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20200407123752_Order")]
    partial class Order
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineStore.Data.Models.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("avalible")
                        .HasColumnType("bit");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("longDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("shortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            id = 4,
                            avalible = true,
                            categoryID = 3,
                            img = "/img/ASPNETinAction.jpg",
                            isFavorite = false,
                            longDesc = "This book is about the ASP.NET Core framework, what it is, and how you can use it to build web applications.",
                            name = "ASP NET Core in Action",
                            price = 1020,
                            shortDesc = "Andrew Lock"
                        },
                        new
                        {
                            id = 5,
                            avalible = true,
                            categoryID = 3,
                            img = "/img/aspnetcoreaz.jpg",
                            isFavorite = false,
                            longDesc = "This book is a phenomenal achievement, and it’s been really exciting to have been along for the ridefrom the beginning.",
                            name = "ASP NET Core A-Z",
                            price = 1400,
                            shortDesc = "Shahed Chowdhuri"
                        },
                        new
                        {
                            id = 6,
                            avalible = true,
                            categoryID = 1,
                            img = "/img/C8.0and.NETCore3.0.jpg",
                            isFavorite = true,
                            longDesc = "Build applications with C#, .NET Core, EntityFramework Core, ASP.NET Core, using Visual Studio Code",
                            name = "C# 8.0 and .NET Core 3.0",
                            price = 1800,
                            shortDesc = "Mark J. Price"
                        },
                        new
                        {
                            id = 7,
                            avalible = true,
                            categoryID = 3,
                            img = "/img/Front‐endDevelopment.jpg",
                            isFavorite = true,
                            longDesc = "There was a time when “backend” and “front‐end” developers were doing pretty different work.",
                            name = "Front‐end Development with ASP.NET Core, Angular, and Bootstrap",
                            price = 1500,
                            shortDesc = "Simone Chiaretta"
                        });
                });

            modelBuilder.Entity("OnlineStore.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            id = 3,
                            categoryName = "ASP",
                            desc = "Books about ASP.NET"
                        });
                });

            modelBuilder.Entity("OnlineStore.Data.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("addres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("OnlineStore.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("bookId")
                        .HasColumnType("int");

                    b.Property<int>("orderID")
                        .HasColumnType("int");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("bookId");

                    b.HasIndex("orderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("OnlineStore.Data.Models.StoreCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StoreCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("bookid")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bookid");

                    b.ToTable("StoreCartItem");
                });

            modelBuilder.Entity("OnlineStore.Data.Models.Book", b =>
                {
                    b.HasOne("OnlineStore.Data.Models.Category", "Category")
                        .WithMany("books")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineStore.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("OnlineStore.Data.Models.Book", "book")
                        .WithMany()
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Data.Models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineStore.Data.Models.StoreCartItem", b =>
                {
                    b.HasOne("OnlineStore.Data.Models.Book", "book")
                        .WithMany()
                        .HasForeignKey("bookid");
                });
#pragma warning restore 612, 618
        }
    }
}
