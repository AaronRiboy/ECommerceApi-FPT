using System;
using FPTFinalProject_API.Model;

namespace FPTFinalProject_API.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=localhost; Database=userdb;User ID=sa;Password=AaronKajen123!;");
		}

        public DbSet<User> Users => Set<User>();



    }
}

