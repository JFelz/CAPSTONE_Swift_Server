using System;
using Microsoft.EntityFrameworkCore;
using CAPSTONE_Swift_Server.Models;
using CAPSTONE_Swift_Server;

namespace CAPSTONE_Swift_Server
{
	public class SwiftDbContext : DbContext
	{
		public DbSet<Administrator> administrators { get; set; }
		public DbSet<Customer> customers { get; set; }
		public DbSet<Order> orders { get; set; }
		public DbSet<Product> products { get; set; }
		public DbSet<Review> reviews { get; set; }
		public DbSet<PaymentType> paymentTypes { get; set; }
		public DbSet<OrderStatus> orderStatuses { get; set; }

        public SwiftDbContext(DbContextOptions<SwiftDbContext> context) : base(context)
        {
        }
    }
}
