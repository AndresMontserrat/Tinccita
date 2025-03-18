using Microsoft.EntityFrameworkCore;
using Tinccita.Application.Exceptions;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;
using Tinccita.Infraestructure.Data;

namespace Tinccita.Infraestructure.Repositories
{
    public class AppointmentAvailableRepository(ApplicationDbContext context) : IAppointmentAvailable
    {
        public async Task<IEnumerable<AppointmentAvailable>> GetAllByService(Guid id)
        {
            var result = await context.AppointmentsAvailable.Where(x => x.ServiceId == id).ToListAsync();
            return result;
        }
        public async Task<int> AddAsync(AppointmentAvailable entity)
        {
            context.Set<AppointmentAvailable>().Add(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await context.Set<AppointmentAvailable>().FindAsync(id);
            if (entity == null)
            {
                throw new ItemNotFoundException($"Item {typeof(AppointmentAvailable).Name} with {id} is not found");
            }
            context.Set<AppointmentAvailable>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> UpdateAsync(AppointmentAvailable entity)
        {
            context.Set<AppointmentAvailable>().Update(entity);
            return await context.SaveChangesAsync();
        }
    }
}
