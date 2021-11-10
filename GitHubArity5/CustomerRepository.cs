using GitHubArity5.Models;
using Microsoft.EntityFrameworkCore;

namespace GitHubArity
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