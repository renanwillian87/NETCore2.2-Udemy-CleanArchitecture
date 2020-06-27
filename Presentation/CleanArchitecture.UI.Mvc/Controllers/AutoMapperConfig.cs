using AutoMapper;
using CleanArchitecture.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
namespace CleanArchitecture.UI.Mvc.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArchitecture.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}