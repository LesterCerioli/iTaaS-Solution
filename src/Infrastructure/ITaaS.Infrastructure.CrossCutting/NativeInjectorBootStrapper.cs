using ITaaS.Infrastructure.Context;
using ITaaS.Modules.Application.Services.Contracts;
using ITaaS.Modules.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace ITaaS.Infrastructure.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infrastructure
            services.AddScoped<IAggraLogRepository>();
            services.AddScoped<ITaaSDbContext>();

            // Application
            services.AddScoped<IAgoraLogAppService, AgoraLogAppService>();

        }
        
    }
}