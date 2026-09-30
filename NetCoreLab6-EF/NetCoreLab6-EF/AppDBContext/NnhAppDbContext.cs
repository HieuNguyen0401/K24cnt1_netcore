using Microsoft.EntityFrameworkCore;
using NetCoreLab6_EF.Models;

namespace NetCoreLab6_EF.Data
{
	public class NnhAppDbContext : DbContext
	{
		public NnhAppDbContext(DbContextOptions<NnhAppDbContext> options)
			: base(options)
		{
		}

		public DbSet<NnhCategory> NnhCategories { get; set; }

		public DbSet<Product> Products { get; set; }
	}
}