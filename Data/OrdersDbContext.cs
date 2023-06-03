using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MenuApi.Data
{
	public class OrdersDbContext : DbContext
	{
		public OrdersDbContext(DbContextOptions<MenuDbContext> options) : base(options)
		{
		}
		public DbSet<OrderModel> Orders { get; set; } = null!;
	}
}