using Microsoft.EntityFrameworkCore;

namespace ElectricShop.Models
{
    public class ElectricDbContext : DbContext
    {
        public ElectricDbContext(DbContextOptions options) : base(options) 
        { 

        }


        public DbSet<OperationSystem> operationSystems { get; set;  }

        public DbSet<Computer> computers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=electric;user=root;password=;");
        }
    }
}
