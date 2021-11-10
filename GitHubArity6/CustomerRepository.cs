using GitHubArity6.Models;
using Microsoft.EntityFrameworkCore;

namespace GitHubArity6
{
    public interface ICustomerRepository : IRepository<Customer>
    {
    }

    public class CustomerRepository : Repository<MyContext, Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbContextFactory<MyContext> factory) : base(factory)
        {
        }
    }
}