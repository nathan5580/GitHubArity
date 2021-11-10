using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GitHubArity6
{
    public interface IRepository<TEntity>
        where TEntity : class, new()
    {
        IQueryable<TEntity> GetAll();
    }
    
    public class Repository<TDbContext, TEntity> : IRepository<TEntity>
        where TEntity : class, new()
        where TDbContext : DbContext
    {
        protected readonly IDbContextFactory<TDbContext> Factory;

        public Repository(IDbContextFactory<TDbContext> factory)
        {
            Factory = factory;
        }
        
        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return Factory.CreateDbContext().Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}", ex);
            }
        }
    }
}