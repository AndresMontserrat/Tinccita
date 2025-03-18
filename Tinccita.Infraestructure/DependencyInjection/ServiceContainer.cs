using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;
using Tinccita.Infraestructure.Repositories;

namespace Tinccita.Infraestructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfraestructureService
            (this IServiceCollection services, IConfiguration config)
        {
            string connectionString_CS = "Tinccita_cs";
            services.AddDbContext<ApplicationDbContext>(option =>
            option.UseSqlite(config.GetConnectionString(connectionString_CS),
            sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(typeof(ServiceContainer).Assembly.FullName);
            }),
            ServiceLifetime.Scoped);

            services.AddScoped<IAppointmentAvailable, AppointmentAvailableRepository>();
            services.AddScoped<IGeneric<AppointmentBookedCustomer>, GenericRepository<AppointmentBookedCustomer>>();
            services.AddScoped<IGeneric<AppointmentBooked>, GenericRepository<AppointmentBooked>>();
            services.AddScoped<IBusiness, BusinessRepository>();
            services.AddScoped<ICategory, CategoryRepository>();
            services.AddScoped<ICustomer, CustomerRepository>();
            services.AddScoped<IService, ServiceRepository>();
            services.AddScoped<ISubcategory, SubcategoryRepository>();

            return services;
        }
    }
}
