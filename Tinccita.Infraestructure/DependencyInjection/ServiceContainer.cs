using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tinccita.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Repositories;
using Tinccita.Domain.Entities;

namespace Tinccita.Infraestructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfraestructureService
            (this IServiceCollection services, IConfiguration config)
        {
            string connectionString = "Default";
            services.AddDbContext<AppDbContext>(option =>
            option.UseSqlite(config.GetConnectionString(connectionString),
            sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(typeof(ServiceContainer).Assembly.FullName);
            }),
            ServiceLifetime.Scoped);

            services.AddScoped<IGeneric<AppointmentAvailable>, GenericRepository<AppointmentAvailable>>();
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
