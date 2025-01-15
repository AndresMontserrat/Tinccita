using Microsoft.Extensions.DependencyInjection;
using Tinccita.Application.Mapping;
using Tinccita.Application.Services.Implementations;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingConfig));
            services.AddScoped<IAppointmentAvailableService, AppointmentAvailableService>();
            services.AddScoped<IAppointmentBookedCustomerService, AppointmentBookedCustomerService>();
            services.AddScoped<IAppointmentBookedService, AppointmentBookedService>();
            services.AddScoped<IBusinessService, BusinessService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<ISubcategoryService, SubcategoryService>();
            return services;
        }
    }
}
