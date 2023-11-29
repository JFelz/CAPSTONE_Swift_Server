using System;
using System.ComponentModel.DataAnnotations;

namespace CAPSTONE_Swift_Server.Models
{
	public class Order
	{
        #region Id

        public int Id { get; set; }
        [Required]

        public string CustomerUid { get; set; }

        #endregion

        #region Navigation

        public List<Product> ProductList { get; set; }

        #endregion

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public long CustomerPhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string Country { get; set; }
        public string TownCity { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public DateTime DateTime { get; set; }
        public double Revenue { get; set; }
        public string ShippingMethod { get; set; }
        public bool Status { get; set; }
        public string PaymentType { get; set; }

    }
}

