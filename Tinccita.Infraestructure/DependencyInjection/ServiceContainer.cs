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
            services.AddScoped<IGeneric<Business>, GenericRepository<Business>>();
            services.AddScoped<IGeneric<Category>, GenericRepository<Category>>();
            services.AddScoped<IGeneric<Customer>, GenericRepository<Customer>>();
            services.AddScoped<IGeneric<Service>, GenericRepository<Service>>();
            services.AddScoped<IGeneric<Subcategory>, GenericRepository<Subcategory>>();

            return services;
        }
    }
}
