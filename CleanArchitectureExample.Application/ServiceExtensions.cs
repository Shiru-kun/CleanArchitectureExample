using CleanArchitectureExample.Application.Behavior;
using CleanArchitectureExample.Domain.Interfaces;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitectureExample.Application
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services) 
        { 
             services.AddAutoMapper(Assembly.GetExecutingAssembly());
             services.AddMediatR(cfg =>
                        cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())
            );
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}
