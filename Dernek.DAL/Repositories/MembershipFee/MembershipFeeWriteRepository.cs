using Dernek.Application.Repositories.MembershipFee;
using Dernek.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DAL.Repositories.MembershipFee
{
    public class MembershipFeeWriteRepository : WriteRepository<MembershipFeeEntity>, IMembershipFeeWriteRepository
    {
        public MembershipFeeWriteRepository(DernekDbContext context) : base(context)
        {
        }
    }
}
