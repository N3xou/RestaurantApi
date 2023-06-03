using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MenuApi.Data
{
	public class MenuDbContext : DbContext
	{
		public MenuDbContext(DbContextOptions<MenuDbContext> options) : base(options)
		{
		}
		public DbSet<ProductModel> Menu { get; set; } = null!;
	}
}