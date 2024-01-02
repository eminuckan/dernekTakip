using Dernek.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dernek.DAL
{
    public class DernekDbContext: DbContext
    {
        public DernekDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<MemberEntity> Members { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var item in datas)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedAt = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }


            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
