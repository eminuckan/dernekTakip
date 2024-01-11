using Dernek.Application.Repositories;
using Dernek.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Dernek.DAL.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly DernekDbContext _context;

        public ReadRepository(DernekDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public virtual IQueryable<T> GetAll(bool tracking = true )
        {
            var query = Table.AsQueryable();
            if ( !tracking )
            {
                query = query.AsNoTracking();
            }

            return query;
        }
        public IQueryable<T> GetWhere( Expression<Func<T , bool>> method , bool tracking = true )
        {
            var query = Table.Where( method );
            if ( !tracking )
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        public async Task<T> GetByIdAsync( string id , bool tracking = true )
        {  
            var query = Table.AsQueryable();
            if ( !tracking )
            {
                query = query.AsNoTracking();
            }

            return await query.FirstOrDefaultAsync( e => e.Id == id );

        }
             

        public async Task<T> GetSingleAsync( Expression<Func<T , bool>> method , bool tracking = true )
        {
            var query = Table.AsQueryable();
            if ( !tracking )
            {
                query = query.AsNoTracking();
            }

            return await query.FirstOrDefaultAsync( method );
        }

        public bool Any(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            return query.Any(e => e.Id == id);
        }
    }
}
