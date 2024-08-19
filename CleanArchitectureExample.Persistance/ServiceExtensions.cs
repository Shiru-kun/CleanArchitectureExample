using CleanArchitectureExample.Domain.Interfaces;
using CleanArchitectureExample.Persistance.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureExample.Persistance
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistanceApp(this IServiceCollection services, IConfiguration configuration) 
        { 
           services.AddScoped<IUnitOfWork, UnitOfWork>();   
           services.AddScoped<IUserService, UserService>();   
           services.AddSingleton<UserContext>();   

        }
    }
}
