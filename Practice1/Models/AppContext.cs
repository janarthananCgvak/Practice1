
using Microsoft.EntityFrameworkCore;
namespace Practice1.Models
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions opts): base(opts)
        {
        }
        public DbSet< Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
