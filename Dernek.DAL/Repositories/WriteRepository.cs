using Dernek.Application.Repositories;
using Dernek.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Dernek.DAL.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly DernekDbContext _context;

        public WriteRepository(DernekDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddAsync(List<T> values)
        {
            await Table.AddRangeAsync(values);
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> Remove(string id)
        {
            T entity = await Table.FindAsync(id);
            return Remove(entity);
        }

        public bool Remove(List<T> values)
        {
            Table.RemoveRange(values);
            return true;
        }

        public bool Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }

        public bool Update(List<T> values)
        {
            Table.UpdateRange(values);
            return true;
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();
    }
}
