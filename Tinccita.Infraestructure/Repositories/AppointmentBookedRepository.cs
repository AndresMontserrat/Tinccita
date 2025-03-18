using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class AppointmentBookedRepository(ApplicationDbContext context) : IAppointmentBooked
    {
        public async Task<IEnumerable<AppointmentBooked>> GetAllByService(Guid id)
        {
            var result = await context.AppointmentsBooked.Where(x => x.ServiceId == id).ToListAsync();
            return result;
        }
        public async Task<int> AddAsync(AppointmentBooked entity)
        {
            context.Set<AppointmentBooked>().Add(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await context.Set<AppointmentBooked>().FindAsync(id);
            if (entity == null)
            {
                throw new ItemNotFoundException($"Item {typeof(AppointmentBooked).Name} with {id} is not found");
            }
            context.Set<AppointmentBooked>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> UpdateAsync(AppointmentBooked entity)
        {
            context.Set<AppointmentBooked>().Update(entity);
            return await context.SaveChangesAsync();
        }
    }
}
