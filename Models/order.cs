using System;
using System.ComponentModel.DataAnnotations;

namespace CAPSTONE_Swift_Server.Models
{
	public class Order
	{
        #region Id

        public int Id { get; set; }
        [Required]

        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public int OrderStatus { get; set; }

        #endregion

        #region Relationships

        public List<Product> ProductList { get; set; }

        #endregion

        #region Navigation

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public long CustomerPhoneNumber { get; set; }
        public string streetAddress { get; set; }
        public string Country { get; set; }
        public string TownCity { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public DateTime DateTime { get; set; }
        public double Revenue { get; set; }
        public string ShippingMethod { get; set; }

        #endregion
    }
}

