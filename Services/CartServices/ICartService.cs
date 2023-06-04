using Microsoft.AspNetCore.Mvc;

namespace MenuApi.Services.CartServices
{
	public interface ICartService
	{
		Task<bool> Order(OrderModel cart);
		//void RemoveProduct(OrderModel cart, ProductModel product);
		//void AddToCart(OrderModel cart, ProductModel product);
	}
}