using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface IAppointmentBookedCustomer
    {
        Task<int> AddAsync(AppointmentBookedCustomer entity);
        Task<int> DeleteAsync(Guid id);
        Task<IEnumerable<AppointmentBookedCustomer>> GetAllByAppointment(Guid id);
        Task<IEnumerable<AppointmentBookedCustomer>> GetAllByCustomer(Guid id);
        Task<int> UpdateAsync(AppointmentBookedCustomer entity);
    }
}
