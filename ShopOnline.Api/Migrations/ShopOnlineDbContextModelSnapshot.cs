﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Data;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    partial class ShopOnlineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Name = "Glossier - Beauty Kit",
                            Price = 200m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A bond intense moisture mask: Moisturizes, Smooths, Adds Body & Shine",
                            ImageURL = "/Images/Beauty/Beauty2.png",
                            Name = "Olaplex - Skin Care Kit",
                            Price = 60m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A kit provided by Curology, containing skin care products",
                            ImageURL = "/Images/Beauty/Beauty3.png",
                            Name = "Cocooil - Organic Coconut Oil",
                            Price = 320m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "A kit provided by Goop, containing skin care and hair care products",
                            ImageURL = "/Images/Beauty/Beauty4.png",
                            Name = "goop - Hair Care and Skin Care Kit",
                            Price = 50m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Amla, Aloe, Probiotics & Hyaluronic Acid: FRESH CITRUS SCENT",
                            ImageURL = "/Images/Beauty/Beauty5.png",
                            Name = "Alo - Supernatural deodorant",
                            Price = 50m,
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Air Pods - in-ear wireless headphones",
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Name = "Air Pods",
                            Price = 120m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "On-ear Golden Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Name = "On-ear Golden Headphones",
                            Price = 140m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "On-ear Black Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Name = "On-ear Black Headphones",
                            Price = 230m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Name = "Sennheiser Digital Camera with Tripod",
                            Price = 2500m,
                            Qty = 105
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Canon Digital Camera - High quality digital camera provided by Canon",
                            ImageURL = "/Images/Electronic/Electronic5.png",
                            Name = "Canon Digital Camera",
                            Price = 2800m,
                            Qty = 115
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Gameboy - Provided by Nintendo",
                            ImageURL = "/Images/Electronic/technology6.png",
                            Name = "Nintendo PC Cam",
                            Price = 1000m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Very comfortable black leather office chair",
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Name = "Black Leather Office Chair",
                            Price = 1850m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Very comfortable pink leather office chair",
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Name = "Pink Leather Office Chair",
                            Price = 1550m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Very comfortable lounge chair",
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Name = "Lounge Chair",
                            Price = 4270m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Very comfortable Silver lounge chair",
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Name = "Silver Lounge Chair",
                            Price = 2120m,
                            Qty = 123
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "White and blue Porcelain Table Lamp",
                            ImageURL = "/Images/Furniture/Furniture6.png",
                            Name = "Porcelain Table Lamp",
                            Price = 315m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Office Table Lamp",
                            ImageURL = "/Images/Furniture/Furniture7.png",
                            Name = "Office Table Lamp",
                            Price = 420m,
                            Qty = 83
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Comfortable Puma Sneakers in most sizes",
                            ImageURL = "/Images/Shoes/Shoes1.png",
                            Name = "Puma Sneakers",
                            Price = 2800m,
                            Qty = 80
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Colorful trainsers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes2.png",
                            Name = "Colorful half-boot",
                            Price = 1350m,
                            Qty = 68
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Red Nike Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes3.png",
                            Name = "Red Nike Air Max",
                            Price = 2900m,
                            Qty = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Nike Colorful Hummel Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes4.png",
                            Name = "Colorful Hummel Trainers",
                            Price = 120m,
                            Qty = 2120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "White with stripes Drip sneaker - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes5.png",
                            Name = "Drip Original Sneaker",
                            Price = 200m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "SA Local brand Bathu sneaker - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes6.png",
                            Name = "Bathu Original Sneaker",
                            Price = 850m,
                            Qty = 150
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-couch",
                            Name = "Furniture"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-shoe-prints",
                            Name = "Shoes"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Sarah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
