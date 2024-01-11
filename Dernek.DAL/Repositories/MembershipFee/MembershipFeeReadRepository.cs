using Dernek.Application.Repositories.MembershipFee;
using Dernek.Core.Entities;
using Dernek.Core.Enums;
using Microsoft.EntityFrameworkCore;
namespace Dernek.DAL.Repositories.MembershipFee
{
    public class MembershipFeeReadRepository : ReadRepository<MembershipFeeEntity>, IMembershipFeeReadRepository
    {
        private readonly DernekDbContext _context;
        public MembershipFeeReadRepository(DernekDbContext context) : base(context)
        {
            _context = context;
        }

        public MembershipFeeEntity GetMonth(string month)
        {
            var query = Table.Where(m => m.Month == (Month)Enum.Parse(typeof(Month), month)).FirstOrDefault();

            return query;
        }
    }
}
