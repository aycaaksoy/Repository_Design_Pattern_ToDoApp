using Microsoft.EntityFrameworkCore;
using Repository_Design_Pattern.Models;

namespace Repository_Design_Pattern.Context
{
    public class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-60DI5A8;Database=DbToDoApp;User Id=aycaa; Password=admin; integrated security=True;");
        }
        public DbSet<Note> Notes { get; set; }
    }
}
