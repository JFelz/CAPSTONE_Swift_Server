﻿// <auto-generated />
using System;
using CAPSTONE_Swift_Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CAPSTONE_Swift_Server.Migrations
{
    [DbContext(typeof(SwiftDbContext))]
    partial class SwiftDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerUid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_uid");

                    b.HasKey("Id")
                        .HasName("pk_carts");

                    b.ToTable("carts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3"
                        });
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_email");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_name");

                    b.Property<long>("CustomerPhoneNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("customer_phone_number");

                    b.Property<string>("CustomerUid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_uid");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_time");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("integer")
                        .HasColumnName("order_status_id");

                    b.Property<int>("PaymentId")
                        .HasColumnType("integer")
                        .HasColumnName("payment_id");

                    b.Property<double>("Revenue")
                        .HasColumnType("double precision")
                        .HasColumnName("revenue");

                    b.Property<string>("ShippingMethod")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("shipping_method");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("street_address");

                    b.Property<string>("TownCity")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("town_city");

                    b.Property<int>("Zipcode")
                        .HasColumnType("integer")
                        .HasColumnName("zipcode");

                    b.HasKey("Id")
                        .HasName("pk_orders");

                    b.ToTable("orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "USA",
                            CustomerEmail = "MahlJ@gmail.com",
                            CustomerName = "John Mahlar",
                            CustomerPhoneNumber = 4324566788L,
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3",
                            DateTime = new DateTime(2023, 11, 27, 20, 23, 19, 573, DateTimeKind.Local).AddTicks(775),
                            OrderStatusId = 2,
                            PaymentId = 1,
                            Revenue = 581.99000000000001,
                            ShippingMethod = "Standard",
                            State = "MS",
                            StreetAddress = "431 Grove Ave",
                            TownCity = "Salt Lake City",
                            Zipcode = 37205
                        });
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_order_statuses");

                    b.ToTable("order_statuses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "active"
                        },
                        new
                        {
                            Id = 2,
                            Name = "closed"
                        },
                        new
                        {
                            Id = 3,
                            Name = "pending"
                        });
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_payment_types");

                    b.ToTable("payment_types", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "visa"
                        },
                        new
                        {
                            Id = 2,
                            Name = "mastercard"
                        },
                        new
                        {
                            Id = 3,
                            Name = "amex"
                        },
                        new
                        {
                            Id = 4,
                            Name = "apple pay"
                        },
                        new
                        {
                            Id = 5,
                            Name = "venmo"
                        });
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("integer")
                        .HasColumnName("admin_id");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl1")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url1");

                    b.Property<string>("ImageUrl2")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url2");

                    b.Property<string>("ImageUrl3")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url3");

                    b.Property<double>("Length")
                        .HasColumnType("double precision")
                        .HasColumnName("length");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<string>("SkateSpots")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("skate_spots");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<double>("Wheelbase")
                        .HasColumnType("double precision")
                        .HasColumnName("wheelbase");

                    b.Property<double>("Width")
                        .HasColumnType("double precision")
                        .HasColumnName("width");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.ToTable("products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = 1,
                            Category = "cruiser",
                            Description = "A snowboard-inspired drop-through for easy around town cruising, relaxed commutes, and mellow downhill.",
                            ImageUrl1 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0073_Photo-Axis-37_Performance_Complete_Combined.jpg?v=1697137406&width=1100",
                            ImageUrl2 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0073_Photo-Axis-37_Performance_Complete_Top.jpg?v=1697137406&width=1100",
                            ImageUrl3 = "https://www.flatspotlongboards.com/wp-content/uploads/landyachtz-longboards-dipper-fish-complete-cruiser-2-600x600.jpg",
                            Length = 37.0,
                            Price = 119.98999999999999,
                            SkateSpots = "Pathways, Campus, Mellow Hills",
                            Title = "AXIS 37",
                            Wheelbase = 119.98999999999999,
                            Width = 8.5
                        },
                        new
                        {
                            Id = 2,
                            AdminId = 1,
                            Category = "carving",
                            Description = "A single-kick carver designed to be agile for all of your out-and-about missions.",
                            ImageUrl1 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Bottom.jpg?v=1697137562&width=1445",
                            ImageUrl2 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Top.jpg?v=1697137562&width=1445",
                            ImageUrl3 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Three-Quarter.jpg?v=1697137562&width=1445",
                            Length = 35.0,
                            Price = 89.989999999999995,
                            SkateSpots = "Pathways, Campus, Mellow Hills",
                            Title = "ARBOR - MISSION",
                            Wheelbase = 21.375,
                            Width = 8.625
                        },
                        new
                        {
                            Id = 3,
                            AdminId = 1,
                            Category = "cruiser",
                            Description = "The Dipper is a pintail designed to bring the compact maneuverability of a cruiser board to a carvy, flexy longboard shape. This board gives you a tight-turning, responsive ride that will make weekday commutes or casual weekend cruises the highlight of your week. The narrow width provides you with incredible control over the edges of the board so you can ride this thing aggressively if you want to or take it easy on those casual cruises. Mellow concave and a subtle rocker will have you feeling right at home on this board. Often referred to as the “best board ever” at skate sessions.",
                            ImageUrl1 = "https://media.rainpos.com/3226/Screenshot_2023_05_31_at_16_49_06_Dipper_Fish.png",
                            ImageUrl2 = "https://www.directiveboardshop.com/cdn/shop/files/weeee.png?v=1683766868&width=1946",
                            ImageUrl3 = "https://www.flatspotlongboards.com/wp-content/uploads/landyachtz-longboards-dipper-fish-complete-cruiser-2-600x600.jpg",
                            Length = 36.0,
                            Price = 169.99000000000001,
                            SkateSpots = "Pathways, Campus, Mellow Hills",
                            Title = "DIPPER - FISH",
                            Wheelbase = 24.289999999999999,
                            Width = 8.6500000000000004
                        },
                        new
                        {
                            Id = 4,
                            AdminId = 1,
                            Category = "carving",
                            Description = "Designed to rally big mountain terrain and conquer World Cup podiums, the Switchblade has proven itself equally adept at getting you to the grocery store and ripping down your local hill safely. The mellow drops, long wheelbase and low ride height combine to offer a drifty, confidence-inspiring feel perfect for riders looking to up their freeride game. The Switchblade 40 is the longer version, offering a more stable ride and slightly easier slide initiation, as well as being a bit more comfortable for taller riders.",
                            ImageUrl1 = "https://landyachtz.com/cdn/shop/files/landyachtz-switchblade-night-40--Graphic-WEB_1200x1200.jpg?v=1683932973",
                            ImageUrl2 = "https://www.sourceboards.com/cdn/shop/products/Landyachtz-2022-Switchblade-40-Chief-Night-Complete_1_1200x1200.jpg?v=1653941378",
                            ImageUrl3 = "https://skate-works-shop.myshopify.com/cdn/shop/products/121CP-DHSB40CHFN-Switchblade40ChiefNightCompleteelasco69swheelup_AD_9975-WEB_1800x1800_0795102e-eefc-4d9e-aaad-ea8623317694_1024x1024@2x.webp?v=1669835848",
                            Length = 40.0,
                            Price = 169.99000000000001,
                            SkateSpots = "City, Alley, Path, Campus, Hill, Mountain",
                            Title = "SWITCHBLADE 40 - CHIEF NIGHTK",
                            Wheelbase = 31.0,
                            Width = 10.0
                        },
                        new
                        {
                            Id = 5,
                            AdminId = 1,
                            Category = "cruiser",
                            Description = "Time-tested maple construction and super low ride height come together with a futuristic rocker profile to create a board that lets you travel through time to sample the very best of what we've learned over 20-plus years of designing boards. The Drop Cat 38 is perfect for taller riders or people looking for a more stable ride.",
                            ImageUrl1 = "https://landyachtz.com/cdn/shop/products/Drop-Cat-38-Black-Seeker-Graphic-WEB_b7086e12-107a-4631-8b8e-f0658f0a4088_1800x1800.jpg?v=1614532582",
                            ImageUrl2 = "https://m.media-amazon.com/images/I/41aHxpyyznL._AC_UF1000,1000_QL80_.jpg",
                            ImageUrl3 = "https://m.media-amazon.com/images/I/41IIyAwWnjL._AC_UF1000,1000_QL80_.jpg",
                            Length = 38.600000000000001,
                            Price = 212.49000000000001,
                            SkateSpots = "Pathways, Campus, Mellow Hills",
                            Title = "DROP CAT 38 - SEEKER BLACK",
                            Wheelbase = 29.300000000000001,
                            Width = 9.9000000000000004
                        });
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<string>("CustomerUid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_uid");

                    b.HasKey("Id")
                        .HasName("pk_reviews");

                    b.ToTable("reviews", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "I love this product!",
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3"
                        },
                        new
                        {
                            Id = 2,
                            Content = "The board was flimsy. Bad product.",
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3"
                        },
                        new
                        {
                            Id = 3,
                            Content = "I bought one for my cousin and he loved it!!",
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3"
                        });
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("bio");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean")
                        .HasColumnName("is_admin");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("phone_number");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("uid");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "I am CEO",
                            Email = "feliz.jovanni@gmail.com",
                            ImageUrl = "https://media.licdn.com/dms/image/D4E03AQFmqmxDnBFpjw/profile-displayphoto-shrink_800_800/0/1695423491664?e=1706140800&v=beta&t=1YCpHpITTc_ME9YctHk0Vte8hhYzmhieSmxiH258VA4",
                            IsAdmin = true,
                            Name = "Jovanni Feliz",
                            PhoneNumber = 6037779999L,
                            Uid = "zcxxFyDPReWizoUPtyPru9w072J3"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "I am a Customer",
                            Email = "MahlJ@gmail.com",
                            ImageUrl = "https://img.freepik.com/free-photo/young-bearded-man-with-striped-shirt_273609-5677.jpg?w=2000",
                            IsAdmin = false,
                            Name = "John Mahlar",
                            PhoneNumber = 4324566788L,
                            Uid = "p84DEdgj4kYhU4VKJfFqZX7unHD3"
                        });
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.Property<int>("CartListId")
                        .HasColumnType("integer")
                        .HasColumnName("cart_list_id");

                    b.Property<int>("ProductListId")
                        .HasColumnType("integer")
                        .HasColumnName("product_list_id");

                    b.HasKey("CartListId", "ProductListId")
                        .HasName("pk_cart_product");

                    b.HasIndex("ProductListId")
                        .HasDatabaseName("ix_cart_product_product_list_id");

                    b.ToTable("cart_product", (string)null);
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrderListId")
                        .HasColumnType("integer")
                        .HasColumnName("order_list_id");

                    b.Property<int>("ProductListId")
                        .HasColumnType("integer")
                        .HasColumnName("product_list_id");

                    b.HasKey("OrderListId", "ProductListId")
                        .HasName("pk_order_product");

                    b.HasIndex("ProductListId")
                        .HasDatabaseName("ix_order_product_product_list_id");

                    b.ToTable("order_product", (string)null);
                });

            modelBuilder.Entity("ProductReview", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("integer")
                        .HasColumnName("products_id");

                    b.Property<int>("ReviewListId")
                        .HasColumnType("integer")
                        .HasColumnName("review_list_id");

                    b.HasKey("ProductsId", "ReviewListId")
                        .HasName("pk_product_review");

                    b.HasIndex("ReviewListId")
                        .HasDatabaseName("ix_product_review_review_list_id");

                    b.ToTable("product_review", (string)null);
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.HasOne("CAPSTONE_Swift_Server.Models.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_product_carts_cart_list_id");

                    b.HasOne("CAPSTONE_Swift_Server.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_product_products_product_list_id");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("CAPSTONE_Swift_Server.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_product_orders_order_list_id");

                    b.HasOne("CAPSTONE_Swift_Server.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_product_products_product_list_id");
                });

            modelBuilder.Entity("ProductReview", b =>
                {
                    b.HasOne("CAPSTONE_Swift_Server.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_review_products_products_id");

                    b.HasOne("CAPSTONE_Swift_Server.Models.Review", null)
                        .WithMany()
                        .HasForeignKey("ReviewListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_review_reviews_review_list_id");
                });
#pragma warning restore 612, 618
        }
    }
}
