using Dernek.Application.Repositories.Member;
using Dernek.Core.Entities;

namespace Dernek.DAL.Repositories.Member
{
    public class MemberReadRepository : ReadRepository<MemberEntity>, IMemberReadRepository
    {
        public MemberReadRepository(DernekDbContext context) : base(context)
        {
        }
    }
}
