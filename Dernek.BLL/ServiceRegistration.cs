using Dernek.Application.Abstractions;
using Dernek.BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dernek.BLL
{
    public static class ServiceRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IMessageService, MessageService>();
        }
    }
}
