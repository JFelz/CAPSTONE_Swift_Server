using System;
namespace CAPSTONE_Swift_Server.Models
{
	public class Newsletteruser
	{
        #region Navigation
        public int Id { get; set; }
		public string CustomerUid { get; set; }
        #endregion

        public string Email { get; set; }
	}
}

