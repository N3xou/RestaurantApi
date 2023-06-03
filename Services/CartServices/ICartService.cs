namespace MenuApi.Services.CartServices
{
	public interface ICartService
	{
		Task<List<OrderModel>> Order(OrderModel cart);
		void RemoveProduct(OrderModel cart, ProductModel product);
		void AddToCart(OrderModel cart, ProductModel product);
	}
}