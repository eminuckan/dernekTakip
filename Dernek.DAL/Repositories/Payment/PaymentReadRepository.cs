using Dernek.Application.Repositories.Payment;
using Dernek.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DAL.Repositories.Payment
{
    public class PaymentReadRepository : ReadRepository<PaymentEntity>, IPaymentReadRepository
    {
        public PaymentReadRepository(DernekDbContext context) : base(context)
        {
        }

        public override IQueryable<PaymentEntity> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            return query.Include(p => p.MembershipFee);
        }
    }
}
