using Clase4Modulo3.Middlewares;
using Clase4Modulo3.Repository;
using Clase4Modulo3.Services.Interfaces;
using Clase4Modulo3.Services;
using Microsoft.EntityFrameworkCore;

namespace Clase4Modulo3.Extensions
{
    public static class DepencyInjection
    {
        public static void AddDependenciasCustom(this IServiceCollection services, ConfigurationManager configuration) 
        {

           services.AddDbContext<ToDoListDBContext>(
                 options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ITareasService, TareasService>();
            services.AddScoped<GlobalExceptionHandler>();

        }

    }
}
