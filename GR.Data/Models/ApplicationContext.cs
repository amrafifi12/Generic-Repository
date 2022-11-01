using GR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repository.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        
         public DbSet<Book> Books { get; set; }
         public DbSet<Author> Author { get; set; }
    }
}
