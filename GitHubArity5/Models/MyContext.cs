using Microsoft.EntityFrameworkCore;

namespace GitHubArity5.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }
        public DbSet<Customer> Customers { get; set; }
    }
}