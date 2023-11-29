using System;
using System.ComponentModel.DataAnnotations;

namespace CAPSTONE_Swift_Server.Models
{
	public class Product
	{
		public int Id { get; set; }
		[Required]

		public int AdminId { get; set; }

        #region Navigation

        public List<Order> OrderList { get; set; }
		public List<Review> ReviewList { get; set; }
		public List<Cart> CartList { get; set; }

        #endregion

        public string Title { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
        public double Price { get; set; }
		public double Length { get; set; }
		public double Width { get; set; }
		public double Wheelbase { get; set; }
		public string SkateSpots { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }

    }
}

