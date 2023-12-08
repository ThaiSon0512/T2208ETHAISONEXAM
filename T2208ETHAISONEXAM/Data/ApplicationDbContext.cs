using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using T2208ETHAISONEXAM.Models;

namespace T2208ETHAISONEXAM.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<T2208ETHAISONEXAM.Models.Department>? Department { get; set; }
		public DbSet<T2208ETHAISONEXAM.Models.Employee>? Employee { get; set; }
	}
}