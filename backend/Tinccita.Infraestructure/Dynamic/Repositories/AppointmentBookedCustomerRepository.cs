using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class AppointmentBookedCustomerRepository(ApplicationDbContext context) : IAppointmentBookedCustomer
    {
        public async Task<IEnumerable<AppointmentBookedCustomer>> GetAllByCustomer(Guid id)
        {
            var result = await context.AppointmentsBookedCustomers.Where(x => x.CustomerGuid == id).ToListAsync();
            return result;
        }
        public async Task<IEnumerable<AppointmentBookedCustomer>> GetAllByAppointment(Guid id)
        {
            var result = await context.AppointmentsBookedCustomers.Where(x => x.AppointmentBookedId == id).ToListAsync();
            return result;
        }
        public async Task<int> AddAsync(AppointmentBookedCustomer entity)
        {
            context.Set<AppointmentBookedCustomer>().Add(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await context.Set<AppointmentBookedCustomer>().FindAsync(id);
            if (entity == null)
            {
                throw new ItemNotFoundException($"Item {typeof(AppointmentBookedCustomer).Name} with {id} is not found");
            }
            context.Set<AppointmentBookedCustomer>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> UpdateAsync(AppointmentBookedCustomer entity)
        {
            context.Set<AppointmentBookedCustomer>().Update(entity);
            return await context.SaveChangesAsync();
        }
    }
}
