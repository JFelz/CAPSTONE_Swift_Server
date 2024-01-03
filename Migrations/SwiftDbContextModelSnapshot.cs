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
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Newsletteruser", b =>
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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.HasKey("Id")
                        .HasName("pk_newsletter_users");

                    b.ToTable("newsletter_users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerUid = "zcxxFyDPReWizoUPtyPru9w072J3",
                            Email = "feliz.jovanni@gmail.com"
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

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("payment_type");

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

                    b.Property<bool>("Status")
                        .HasColumnType("boolean")
                        .HasColumnName("status");

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
                            DateTime = new DateTime(2024, 1, 2, 18, 33, 20, 394, DateTimeKind.Local).AddTicks(9803),
                            PaymentType = "visa",
                            Revenue = 581.99000000000001,
                            ShippingMethod = "Standard",
                            State = "MS",
                            Status = false,
                            StreetAddress = "431 Grove Ave",
                            TownCity = "Salt Lake City",
                            Zipcode = 37205
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
                        },
                        new
                        {
                            Id = 6,
                            AdminId = 1,
                            Category = "downhill",
                            Description = "A pillar of the Landyachtz DH line for over a decade, the Evo has been under the feet of 3 World Champions as well as countless race winners and podium contenders. The Evo 40 offers a drifty and stable ride that will fill any day in the hills with casually fast runs.",
                            ImageUrl1 = "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Setup-WEB-Graphic_1800x1800.jpg?v=1628815758",
                            ImageUrl2 = "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Setup-WEB-Grip_1800x1800.jpg?v=1628815758",
                            ImageUrl3 = "https://landyachtz.com/cdn/shop/products/Evo-40-Spectrum-Alt-Cover-WEB-Angle-01_1800x1800.jpg?v=1628815758",
                            Length = 39.0,
                            Price = 259.99000000000001,
                            SkateSpots = "Hill, Mountain, Race Track",
                            Title = "EVO 40 - SPECTRUM",
                            Wheelbase = 31.699999999999999,
                            Width = 9.8000000000000007
                        },
                        new
                        {
                            Id = 7,
                            AdminId = 1,
                            Category = "downhill",
                            Description = "Will it freeride? Obviously. Will it also grip? Heck yes! Clayton Arthurs is one of the most versatile members of the Landyachtz team and he wanted his pro board to be able to make the switch from race track to slide jam just as comfortably as he can. The Blaze is designed to be equally effective with small slalom trucks on it for tons of grip, or with 155mm symmetrical trucks and freeride wheels for huge standup slides.",
                            ImageUrl1 = "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboardgraphic_AD_4761-WEB_b00e1698-5cc0-4f79-bb20-e97ae05c4d55_1800x1800.jpg?v=1646115057",
                            ImageUrl2 = "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboard4_AD_4787-WEB_3f68fa55-dce3-4f93-a0cc-8d3a50a0f4bd_1800x1800.jpg?v=1646115057",
                            ImageUrl3 = "https://landyachtz.com/cdn/shop/products/122CP-DHCABC-BCCruiserskateboardwheeldown_AD_4769-WEB_8654a3fe-f1ef-4342-b733-4663fe4276e3_1800x1800.jpg?v=1646115057",
                            Length = 34.0,
                            Price = 299.99000000000001,
                            SkateSpots = "Pathways,Steep Hills, Big Mountain Road, all terrain",
                            Title = "BLAZE - PT",
                            Wheelbase = 23.699999999999999,
                            Width = 9.0
                        },
                        new
                        {
                            Id = 8,
                            AdminId = 1,
                            Category = "dance",
                            Description = "Designed as an intuitive carving and pumping board, the Dervish Sama longboard is low and easy to ride for both the first-time skater looking to cruise around town and the experienced rider seeking a soulful, snowboard-inspired ride and the ability to explore longboard dancing and freestyle.",
                            ImageUrl1 = "https://i.pinimg.com/originals/36/2b/64/362b64f26bfaa8cdd77b3efacc2545fc.png",
                            ImageUrl2 = "https://i.pinimg.com/originals/25/51/a9/2551a9ef0fc02f9dacd3a5fa4fa5f2b8.png",
                            ImageUrl3 = "https://www.loadedboards.com/cdn/shop/files/Loaded-Dervish-Sama-2023-complete-profile-2048p.jpg?v=1683235420&width=2036",
                            Length = 42.799999999999997,
                            Price = 329.99000000000001,
                            SkateSpots = "Pathways, Campus, Mellow Hills",
                            Title = "DERVISH SAMA",
                            Wheelbase = 31.5,
                            Width = 9.0
                        },
                        new
                        {
                            Id = 9,
                            AdminId = 1,
                            Category = "dance",
                            Description = "Since 2008 Loaded has been on the forefront of longboard dancing. The Tarab II deepens our roots and seeks to advance modern longboard dancing through thoughtful design and material evolution. Ideal for riders who want a versatile and well-rounded platform for surfy boardwalking lines, smooth freestyle trickery, and everything in between.",
                            ImageUrl1 = "https://i.pinimg.com/originals/06/60/39/0660399607e658a1c527907ba5050811.jpg",
                            ImageUrl2 = "https://i.pinimg.com/originals/08/d2/97/08d2976506d5171067010399673cc000.jpg",
                            ImageUrl3 = "https://thuroshop.com/cdn/shop/products/Loaded-Tarab-II-Complete-profile-2048p_720x_8234d16f-d563-4243-91f1-ac50fdded4e1.jpg?v=1677611277",
                            Length = 47.0,
                            Price = 444.99000000000001,
                            SkateSpots = "Pathways, Campus, Mellow Hills",
                            Title = "TARAB II",
                            Wheelbase = 31.25,
                            Width = 9.5
                        },
                        new
                        {
                            Id = 10,
                            AdminId = 1,
                            Category = "electric",
                            Description = "Dubbed City Rider 3 for its evolution in skateboarding, this masterpiece speaks to both new riders and seasoned enthusiasts. We understand that whether you're gliding on city asphalt or bustling streets, the allure of off-road skating remains. Safety, the essence of your experience, is ingeniously woven into the City Rider 3’s DNA. With large 150mm wheels and a wide truck long board, you’re equipped to conquer obstacles with confidence, and the enhanced stability makes each ride a testament to your secure journey.",
                            ImageUrl1 = "https://i.pinimg.com/originals/81/0e/cd/810ecd7a3a7f76595090e15539884a30.jpg",
                            ImageUrl2 = "https://i.pinimg.com/originals/f4/10/9f/f4109fc8f6c82c6988378481d43bc535.jpg",
                            ImageUrl3 = "https://i.pinimg.com/originals/ad/47/11/ad4711f25374e57ed42551144305b265.jpg",
                            Length = 42.799999999999997,
                            Price = 899.99000000000001,
                            SkateSpots = "Hill, Mountain, Race Track, all terrain",
                            Title = "SWIFT CITY RIDER 3",
                            Wheelbase = 150.0,
                            Width = 9.0
                        },
                        new
                        {
                            Id = 11,
                            AdminId = 1,
                            Category = "pintail",
                            Description = "Dropped low, like the Apex 34 and Apex 37, the Pintail 43 is a plate special with all the fixins to satiate your longboard hunger. This tasty delicacy is 43 inches of medium rare satisfaction, served with a slight concave, and the finest graphic art au jus by Joe Hodnicki....",
                            ImageUrl1 = "https://shop.originalskateboards.com/cdn/shop/products/Maple-Pintail-43-complete-2-1_f30099a0-e636-473f-abb0-f13b8ade70f7_460x.jpg?v=1666908787",
                            ImageUrl2 = "https://shop.originalskateboards.com/cdn/shop/products/2016_Pintail_43_01-e1478098471915_50de8da7-9c58-4a2f-8dee-d3853f160a6a_460x.jpg?v=1666908788",
                            ImageUrl3 = "https://shop.originalskateboards.com/cdn/shop/products/2016_Pintail_43_08-e1478098402677_bd220c4c-5164-4f36-b66c-8d4137426c4d_460x.jpg?v=1666908788",
                            Length = 43.0,
                            Price = 239.99000000000001,
                            SkateSpots = "Pathways, Campus, Mellow Hills",
                            Title = "PINTAIL 43",
                            Wheelbase = 29.5,
                            Width = 9.0
                        },
                        new
                        {
                            Id = 12,
                            AdminId = 1,
                            Category = "pintail",
                            Description = "Our favorite mini-carver sprouted a kicktail, and things have never been the same. Let the Derringer 33 manual its way, your way, and straight into your heart with 3 killer new graphics. ",
                            ImageUrl1 = "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-Longboardresurface_c7935af0-e160-4bd5-bf67-1aa8714a9f45.jpg?v=1597175756",
                            ImageUrl2 = "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-LongboardV4_f7cc2812-c11f-47cf-894d-92b99ef96c2b.jpg?v=1597175756",
                            ImageUrl3 = "https://shop.originalskateboards.com/cdn/shop/products/Derringer-33-LongboardV2_655b4655-7808-421a-8c35-2421796a27e3.jpg?v=1597175756",
                            Length = 33.0,
                            Price = 199.99000000000001,
                            SkateSpots = "Pathways, Campus, Mellow Hills",
                            Title = "DERRINGER 33",
                            Wheelbase = 29.5,
                            Width = 9.0
                        },
                        new
                        {
                            Id = 13,
                            AdminId = 1,
                            Category = "freeride",
                            Description = "The Basalt Tesseract integrates dual kicktails, rocker, wheel well flares, W concave, and multiple wheelbase options into a lightweight package designed for hilly descents, snappy slides, lofty ollies, techy manual combos, and cross-steps galore.\r\n\r\nBuilding on our experience manufacturing the Tarab, we’ve updated the Basalt Tesseract with a high-performance, eco-conscious basalt fabric construction for a lighter, damper, and more freestyle-friendly longboard. Get lit with lava.",
                            ImageUrl1 = "https://www.kickpush.com.au/assets/alt_1/786143.jpg?20230816102317",
                            ImageUrl2 = "https://www.kickpush.com.au/assets/full/786143.jpg?20230816102609",
                            ImageUrl3 = "https://m.media-amazon.com/images/I/71FYI3wbXGL.jpg",
                            Length = 39.0,
                            Price = 339.99000000000001,
                            SkateSpots = "Pathways, Campus, Mellow Hills, City Streets",
                            Title = "BASALT TESSERACT",
                            Wheelbase = 26.0,
                            Width = 9.5
                        },
                        new
                        {
                            Id = 14,
                            AdminId = 1,
                            Category = "beginner",
                            Description = "The Big Dipper is like a magic carpet with wheels. Coming in at 42.2” long and boasting a healthy amount of flex, this is a longboard in the classic sense of the word. Because of its length, the Big Dipper is very forgiving to ride, whether you are a beginner learning to skate or someone trying to push the limits of what a flexy longboard can do. This beast is the perfect choice for anyone looking for a smooth & stable ride with lots of flow and surf style.",
                            ImageUrl1 = "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardgraphic_AD_4748-WEB_1800x1800.jpg?v=1651272223",
                            ImageUrl2 = "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardgrip_AD_4749-WEB_1800x1800.jpg?v=1651272223",
                            ImageUrl3 = "https://landyachtz.com/cdn/shop/products/122CP-LBBDPMTN-BigDipperMountainskateboardwheeldown_AD_4764-WEB_1800x1800.jpg?v=1651272223",
                            Length = 42.200000000000003,
                            Price = 249.99000000000001,
                            SkateSpots = "Pathways, Campus, Mellow Hills, City Streets, Beach",
                            Title = "BIG DIPPER - MOUNTAIN",
                            Wheelbase = 29.800000000000001,
                            Width = 9.4800000000000004
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

                    b.Property<int>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("rating");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("subject");

                    b.HasKey("Id")
                        .HasName("pk_reviews");

                    b.ToTable("reviews", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "I love this product!",
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3",
                            Rating = 5,
                            Subject = "I approve!"
                        },
                        new
                        {
                            Id = 2,
                            Content = "The board was flimsy. Bad product.",
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3",
                            Rating = 1,
                            Subject = "Don't recommend! Bad Product."
                        },
                        new
                        {
                            Id = 3,
                            Content = "I bought one for my cousin and he loved it!!",
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3",
                            Rating = 4,
                            Subject = "Great purchase! Happy Customer"
                        });
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.User", b =>
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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

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

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerUid = "zcxxFyDPReWizoUPtyPru9w072J3",
                            Email = "feliz.jovanni@gmail.com",
                            IsAdmin = true,
                            Name = "Jovanni Feliz",
                            PhoneNumber = 6037779999L
                        },
                        new
                        {
                            Id = 2,
                            CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3",
                            Email = "MahlJ@gmail.com",
                            IsAdmin = false,
                            Name = "John Mahlar",
                            PhoneNumber = 4324566788L
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
