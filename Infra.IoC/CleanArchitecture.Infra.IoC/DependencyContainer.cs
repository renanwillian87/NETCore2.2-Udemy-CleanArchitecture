using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Data.Repository;

namespace CleanArchitecture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // application layer
            services.AddScoped<ICourseService, CourseService>();

            // infra.data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}