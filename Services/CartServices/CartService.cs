using Microsoft.EntityFrameworkCore;

namespace MenuApi.Services.CartServices
{
	public class CartService
	{
		private readonly OrdersDbContext _context;
		public CartService(OrdersDbContext context)
		{
			_context = context;
		}

		// adds the cart to the Orders database
		public async Task<List<OrderModel>> Order(OrderModel cart)
		{
			_context.Orders.Add(cart);
			await _context.SaveChangesAsync();
			return await _context.Orders.ToListAsync();
		}
		// deletes a product from users cart, 
		public void RemoveProduct(OrderModel cart, ProductModel product)
		{
			cart.Products.Remove(product);
			return;
		}
		public void AddToCart(OrderModel cart, ProductModel product)
		{
			cart.Products.Add(product);
			return;
		}
	}
}
