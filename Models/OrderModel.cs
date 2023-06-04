namespace MenuApi.Models
{
	public class OrderModel
	{
		public int Id { get; set; }
		private List<ProductModel> products = new List<ProductModel>();

		public List<ProductModel> Products
		{
			get { return products; }
			set { products = value; }
		}

		public int TotalPrice
		{
			get { return Products.Sum(product => product.Price); }
		}
	}
}
