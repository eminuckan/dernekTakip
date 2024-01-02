using Dernek.Application.Repositories.Member;
using Dernek.DAL.Repositories.Member;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Dernek.DAL
{
    public static class ServiceRegistration
    {
        public static void AddDALServices(this IServiceCollection services)
        {
            services.AddDbContext<DernekDbContext>(o => o.UseJet($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\source\\Dernek\\Dernek.accdb;Persist Security Info=False;"));
            services.AddScoped<IMemberReadRepository , MemberReadRepository>();
            services.AddScoped<IMemberWriteRepository , MemberWriteRepository>();
        }
    }
}
