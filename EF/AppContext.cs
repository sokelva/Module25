using EF;
using Microsoft.EntityFrameworkCore;

namespace FirstApp
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Database=EF;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
