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

        public IQueryable<T> GetAll(bool tracking = true )
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
        {  // GetById gibi generic yapılanmalarda değersel çalışacaksak o değeri temsil eden bir arayüz veya sınıf tasarlamamız gerekiyor. Çünkü T sınıfı generic bir sınıf. Biz burada önceden yaptığımız BaseEntity sınıfını kullanacağız. Bunun yerine bir Interface yazıp onu da kullanabilirdik. Bu yönteme Marker Pattern adı veriliyor. İkinci bir yöntem ise kullandığımız ORM Ef Core için olan FindAsync metoduna direkt id vererek bulmak olacak.
           //=> await Table.FirstOrDefaultAsync( e => e.Id == Guid.Parse(id) ); Marker Pattern

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
    }
}
