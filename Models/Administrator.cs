using System;
using System.ComponentModel.DataAnnotations;

namespace CAPSTONE_Swift_Server.Models
{
	public class Administrator
	{
        #region Id

        public int Id { get; set; }
		[Required]
		public int PaymentId { get; set; }

        #endregion

        #region Navigation

        public string Name { get; set; }
		public string Email { get; set; }
		public long PhoneNumber { get; set; }
		public string ImageUrl { get; set; }

        #endregion
    }
}

