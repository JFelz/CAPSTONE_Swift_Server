namespace CAPSTONE_Swift_Server.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string CustomerUid { get; set; }

        #region Navigation
        public List<Product> ProductList { get; set; }
        #endregion
    }
}
