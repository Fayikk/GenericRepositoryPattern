using GenericRepositoryPattern.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPattern.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
