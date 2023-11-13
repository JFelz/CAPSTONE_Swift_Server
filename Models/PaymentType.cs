using System;
using System.ComponentModel.DataAnnotations;
namespace CAPSTONE_Swift_Server.Models
{
	public class PaymentType
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
    }
}

