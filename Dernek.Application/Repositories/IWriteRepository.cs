using Dernek.Core.Entities;
using System.Linq.Expressions;

namespace Dernek.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddAsync(List<T> values);
        bool Remove(T entity);
        Task<bool> Remove(string id);
        bool Remove(List<T> values);
        bool Update(T entity);
        bool Update(List<T> values);
        Task<int> SaveAsync();
    }
}
