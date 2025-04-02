
using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface IAppointmentBooked
    {
        Task<int> AddAsync(AppointmentBooked entity);
        Task<int> DeleteAsync(Guid id);
        Task<IEnumerable<AppointmentBooked>> GetAllByService(Guid id);
        Task<int> UpdateAsync(AppointmentBooked entity);
    }
}
