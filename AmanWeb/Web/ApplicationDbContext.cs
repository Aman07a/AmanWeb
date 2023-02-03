using AmanWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AmanWeb.Web
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Category> Category { get; set; }
	}
}
