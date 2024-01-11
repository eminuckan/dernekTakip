using Dernek.Core.Entities;
using Dernek.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace Dernek.DAL
{
    public class DernekDbContext: DbContext
    {
        public DernekDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<MemberEntity> Members { get; set; }
        public DbSet<MembershipFeeEntity> MemberFees { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var months = Enum.GetValues(typeof(Month)).Cast<Month>();
            foreach (var month in months)
            {
                modelBuilder.Entity<MembershipFeeEntity>().HasData(new MembershipFeeEntity { Month = month, Fee = 100, Id = Guid.NewGuid().ToString()});
            }
        }

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
