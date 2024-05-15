using Domain.Common;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DBContext _dbContext;

        public Repository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
            _dbContext.SaveChanges();
        }
    }
}
