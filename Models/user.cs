using System;
using System.ComponentModel.DataAnnotations;

namespace CAPSTONE_Swift_Server.Models
{
	public class User
	{
        #region Id

        public int Id { get; set; }
		[Required]
        public string? Uid { get; set; }

        #endregion

        public string Name { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
    }
}

