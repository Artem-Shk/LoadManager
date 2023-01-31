using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace LoadManager.Model
{
	public class AspNetUser
	{
		[Key]
		public int Id { get; set; }
		public string? UserName { get; set; }
		public string? NormilizedUserName { get; set; }
		public string? Email { get; set; }
		public string? NormilizedEmail { get; set; }

		public string? EmailConfirmed { get; set; }

		public string? PasswordHash { get; set; }

		public string? SecurityStamp { get; set; }

		public string? ConcurrencyStamp { get; set; }

		public string? PhoneNumber { get; set; }

		public string? PhoneNumberConfirmed { get; set; }

		public bool TwoFactorEnabled { get; set; }

		public bool LockoutEnd { get; set; }

		public bool LockoutEnabled { get; set; }

		public int AccesFailedCount { get; set; }
	}

	public class AspNetUsersContext : DbContext
	{
		public AspNetUsersContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<AspNetUser> AspNetUsers { get; set; }
		
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
		}
	}
}

