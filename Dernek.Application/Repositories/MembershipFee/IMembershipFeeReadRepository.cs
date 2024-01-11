using Dernek.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Application.Repositories.MembershipFee
{
    public interface IMembershipFeeReadRepository : IReadRepository<MembershipFeeEntity>
    {
        MembershipFeeEntity GetMonth(string month);
    }
}
