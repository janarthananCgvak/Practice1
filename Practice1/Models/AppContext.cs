
using Microsoft.EntityFrameworkCore;
namespace Practice1.Models
{
    public class ApplicationContext :DbContext
    {
        //this is referred throughout the project
        public ApplicationContext(DbContextOptions opts): base(opts)
        {
        }
        public DbSet< Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
