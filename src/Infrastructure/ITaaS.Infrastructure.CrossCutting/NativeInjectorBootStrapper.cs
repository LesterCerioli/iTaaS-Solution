using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITaaS.Infrastructure.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infrastructure
            services.AddScoped<IPacienteRepository>();
            services.AddScoped<AchePacientesContext>();

            // Application
            services.AddScoped<IPacienteService, PacienteService>();

        }
        
    }
}