using Microsoft.EntityFrameworkCore;

namespace GitHubArity6.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }
        public DbSet<Customer> Customers { get; set; }
    }
}