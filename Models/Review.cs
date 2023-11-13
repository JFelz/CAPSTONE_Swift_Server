using System;
namespace CAPSTONE_Swift_Server.Models
{
	public class Review
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public string Content { get; set; }

        #region Relationships

        public List<Product> Products { get; set; }

        #endregion
    }
}

