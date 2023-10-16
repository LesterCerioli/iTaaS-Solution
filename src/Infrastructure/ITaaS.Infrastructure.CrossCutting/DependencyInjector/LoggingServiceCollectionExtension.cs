using ITaaS.Infrastructure.CrossCutting.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace ITaaS.Infrastructure.CrossCutting.DependencyInjector
{
    public static class LoggingServiceCollectionExtension
    {
        public static IServiceCollection AddLogger(this IServiceCollection services)
        {
            var logger = LoggerManager.CreateLogger();
            services.AddSingleton(logger);
            return services;
        }
    }
}