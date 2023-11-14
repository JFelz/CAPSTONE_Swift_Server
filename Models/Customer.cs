using System;
using System.ComponentModel.DataAnnotations;

namespace CAPSTONE_Swift_Server.Models
{
	public class Customer
	{
        #region Id

        public int Id { get; set; }
		[Required]

        #endregion

        #region Navigation

        public string Name { get; set; }
		public string Email { get; set; }
		public long PhoneNumber { get; set; }
		public string ImageUrl { get; set; }

        #endregion
    }
}

