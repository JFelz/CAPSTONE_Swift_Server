using System;
using CAPSTONE_Swift_Server;
using Microsoft.EntityFrameworkCore;
using CAPSTONE_Swift_Server.Models;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace CAPSTONE_Swift_Server
{
	public class SwiftDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<PaymentType> PaymentTypes { get; set; }
		public DbSet<OrderStatus> OrderStatuses { get; set; }
		public DbSet<Cart> Carts { get; set; }

        public SwiftDbContext(DbContextOptions<SwiftDbContext> context) : base(context)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed data with campsite types
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User { Id = 1, Uid = "zcxxFyDPReWizoUPtyPru9w072J3", Name = "Jovanni Feliz", Bio = "I am CEO", Email = "feliz.jovanni@gmail.com", PhoneNumber = 6037779999, ImageUrl = "https://media.licdn.com/dms/image/D4E03AQFmqmxDnBFpjw/profile-displayphoto-shrink_800_800/0/1695423491664?e=1706140800&v=beta&t=1YCpHpITTc_ME9YctHk0Vte8hhYzmhieSmxiH258VA4", IsAdmin = true },
                new User { Id = 2, Uid = "p84DEdgj4kYhU4VKJfFqZX7unHD3", Name = "John Mahlar", Bio = "I am a Customer", Email = "MahlJ@gmail.com", PhoneNumber = 4324566788, ImageUrl = "https://img.freepik.com/free-photo/young-bearded-man-with-striped-shirt_273609-5677.jpg?w=2000", IsAdmin = false },
            });

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product { Id = 1, AdminId = 1, Title = "AXIS 37", Description = "A snowboard-inspired drop-through for easy around town cruising, relaxed commutes, and mellow downhill.", Category = "cruiser", Price = 119.99, Length = 37, Width = 8.5, Wheelbase = 119.99, SkateSpots = "Pathways, Campus, Mellow Hills",ImageUrl1 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0073_Photo-Axis-37_Performance_Complete_Combined.jpg?v=1697137406&width=1100", ImageUrl2 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0073_Photo-Axis-37_Performance_Complete_Top.jpg?v=1697137406&width=1100", ImageUrl3 = "https://www.flatspotlongboards.com/wp-content/uploads/landyachtz-longboards-dipper-fish-complete-cruiser-2-600x600.jpg" },
                new Product { Id = 2, AdminId = 1, Title = "ARBOR - MISSION", Description = "A single-kick carver designed to be agile for all of your out-and-about missions.", Category = "carving", Price = 89.99, Length = 35, Width = 8.625, Wheelbase = 21.375, SkateSpots = "Pathways, Campus, Mellow Hills",ImageUrl1 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Bottom.jpg?v=1697137562&width=1445", ImageUrl2 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Top.jpg?v=1697137562&width=1445", ImageUrl3 = "https://www.arborcollective.com/cdn/shop/files/ABR-COM-0075_Photo-Mission_Performance_Complete_Three-Quarter.jpg?v=1697137562&width=1445" },
                new Product { Id = 3, AdminId = 1, Title = "DIPPER - FISH", Description = "The Dipper is a pintail designed to bring the compact maneuverability of a cruiser board to a carvy, flexy longboard shape. This board gives you a tight-turning, responsive ride that will make weekday commutes or casual weekend cruises the highlight of your week. The narrow width provides you with incredible control over the edges of the board so you can ride this thing aggressively if you want to or take it easy on those casual cruises. Mellow concave and a subtle rocker will have you feeling right at home on this board. Often referred to as the “best board ever” at skate sessions.", Category = "cruiser", Price = 169.99, Length = 36, Width = 8.65, Wheelbase = 24.29, SkateSpots = "Pathways, Campus, Mellow Hills", ImageUrl1 = "https://media.rainpos.com/3226/Screenshot_2023_05_31_at_16_49_06_Dipper_Fish.png", ImageUrl2 = "https://www.directiveboardshop.com/cdn/shop/files/weeee.png?v=1683766868&width=1946", ImageUrl3 = "https://www.flatspotlongboards.com/wp-content/uploads/landyachtz-longboards-dipper-fish-complete-cruiser-2-600x600.jpg" },
                new Product { Id = 4, AdminId = 1, Title = "SWITCHBLADE 40 - CHIEF NIGHTK", Description = "Designed to rally big mountain terrain and conquer World Cup podiums, the Switchblade has proven itself equally adept at getting you to the grocery store and ripping down your local hill safely. The mellow drops, long wheelbase and low ride height combine to offer a drifty, confidence-inspiring feel perfect for riders looking to up their freeride game. The Switchblade 40 is the longer version, offering a more stable ride and slightly easier slide initiation, as well as being a bit more comfortable for taller riders.", Category = "carving", Price = 169.99, Length = 40, Width = 10, Wheelbase = 31, SkateSpots = "City, Alley, Path, Campus, Hill, Mountain",ImageUrl1 = "https://landyachtz.com/cdn/shop/files/landyachtz-switchblade-night-40--Graphic-WEB_1200x1200.jpg?v=1683932973", ImageUrl2 = "https://www.sourceboards.com/cdn/shop/products/Landyachtz-2022-Switchblade-40-Chief-Night-Complete_1_1200x1200.jpg?v=1653941378", ImageUrl3 = "https://skate-works-shop.myshopify.com/cdn/shop/products/121CP-DHSB40CHFN-Switchblade40ChiefNightCompleteelasco69swheelup_AD_9975-WEB_1800x1800_0795102e-eefc-4d9e-aaad-ea8623317694_1024x1024@2x.webp?v=1669835848" },
                new Product { Id = 5, AdminId = 1, Title = "DROP CAT 38 - SEEKER BLACK", Description = "Time-tested maple construction and super low ride height come together with a futuristic rocker profile to create a board that lets you travel through time to sample the very best of what we've learned over 20-plus years of designing boards. The Drop Cat 38 is perfect for taller riders or people looking for a more stable ride.", Category = "cruiser", Price = 212.49, Length = 38.6, Width = 9.9, Wheelbase = 29.3, SkateSpots = "Pathways, Campus, Mellow Hills",ImageUrl1 = "https://landyachtz.com/cdn/shop/products/Drop-Cat-38-Black-Seeker-Graphic-WEB_b7086e12-107a-4631-8b8e-f0658f0a4088_1800x1800.jpg?v=1614532582", ImageUrl2 = "https://m.media-amazon.com/images/I/41aHxpyyznL._AC_UF1000,1000_QL80_.jpg", ImageUrl3 = "https://m.media-amazon.com/images/I/41IIyAwWnjL._AC_UF1000,1000_QL80_.jpg" },
            });

            modelBuilder.Entity<Order>().HasData(new Order[]
            {
                new Order { Id = 1, CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3", PaymentId = 1, OrderStatusId = 2, CustomerName = "John Mahlar", CustomerEmail = "MahlJ@gmail.com", CustomerPhoneNumber = 4324566788, StreetAddress = "431 Grove Ave", Country = "USA", TownCity = "Salt Lake City", State = "MS", Zipcode = 37205, DateTime = DateTime.Now, Revenue = 581.99, ShippingMethod = "Standard"},
            });

            modelBuilder.Entity<PaymentType>().HasData(new PaymentType[]
            {
                new PaymentType { Id = 1, Name = "visa"},
                new PaymentType { Id = 2, Name = "mastercard"},
                new PaymentType { Id = 3, Name = "amex"},
                new PaymentType { Id = 4, Name = "apple pay"},
                new PaymentType { Id = 5, Name = "venmo"},
            });

            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus[]
            {
                new OrderStatus { Id = 1, Name = "active"},
                new OrderStatus { Id = 2, Name = "closed"},
                new OrderStatus { Id = 3, Name = "pending"},
            });


            modelBuilder.Entity<Cart>().HasData(new Cart[]
            {
                new Cart { Id = 1, CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3"},
            });

            modelBuilder.Entity<Review>().HasData(new Review[]
            {
                new Review { Id = 1, CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3", Content = "I love this product!" },
                new Review { Id = 2, CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3", Content = "The board was flimsy. Bad product." },
                new Review { Id = 3, CustomerUid = "p84DEdgj4kYhU4VKJfFqZX7unHD3", Content = "I bought one for my cousin and he loved it!!" },
            });
        }
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 => optionsBuilder
     .UseNpgsql()
     .UseSnakeCaseNamingConvention();
    }
}
