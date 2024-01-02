using Dernek.Application.Repositories.Member;
using Dernek.Core.Entities;

namespace Dernek.DAL.Repositories.Member
{
    public class MemberWriteRepository : WriteRepository<MemberEntity>, IMemberWriteRepository
    {
        public MemberWriteRepository(DernekDbContext context) : base(context)
        {
        }
    }
}
