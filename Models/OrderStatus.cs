using System;
using System.ComponentModel.DataAnnotations;

namespace CAPSTONE_Swift_Server.Models
{
	public class OrderStatus
	{
		public int Id { get; set; }
		[Required]

		public int Name { get; set; }
    }
}

