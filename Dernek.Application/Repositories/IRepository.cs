using Dernek.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dernek.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
