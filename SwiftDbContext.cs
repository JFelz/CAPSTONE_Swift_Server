using System;
using Microsoft.EntityFrameworkCore;
using CAPSTONE_Swift_Server.Models;
using CAPSTONE_Swift_Server;

namespace CAPSTONE_Swift_Server
{
	public class SwiftDbContext : DbContext
	{
		public DbSet<Administrator> Administrators { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<PaymentType> PaymentTypes { get; set; }
		public DbSet<OrderStatus> OrderStatuses { get; set; }

        public SwiftDbContext(DbContextOptions<SwiftDbContext> context) : base(context)
        {
        }
    }
}
