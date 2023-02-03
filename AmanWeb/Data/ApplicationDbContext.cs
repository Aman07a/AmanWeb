using AmanWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AmanWeb.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<Category> Category { get; set; }
	}
}
