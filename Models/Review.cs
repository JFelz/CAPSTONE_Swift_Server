using System;
namespace CAPSTONE_Swift_Server.Models
{
	public class Review
	{
		public int Id { get; set; }
		public string CustomerUid { get; set; }
		public string Content { get; set; }

        #region Navigation

        public List<Product> Products { get; set; }

        #endregion
    }
}

