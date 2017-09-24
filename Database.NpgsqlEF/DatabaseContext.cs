using Database.NpgsqlEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database.NpgsqlEF
{
    public class DatabaseContext : DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var config = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

            optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
		}

		public DbSet<Member> Members { get; set; }
	}
}
