using Dernek.Application.Repositories.Payment;
using Dernek.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DAL.Repositories.Payment
{
    public class PaymentWriteRepository : WriteRepository<PaymentEntity>, IPaymentWriteRepository
    {
        public PaymentWriteRepository(DernekDbContext context) : base(context)
        {
        }
    }
}
