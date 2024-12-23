using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentBooked;

namespace Tinccita.Application.Services.Interfaces
{
    public interface IAppointmentBookedService
    {
        Task<IEnumerable<GetAppointmentBooked>> GetAllAsync();
        Task<GetAppointmentBooked> GetByIdAsync(int id);
        Task<ServiceResponse> AddAsync(CreateAppointmentBooked appointmentBooked);
        Task<ServiceResponse> UpdateAsync(UpdateAppointmentBooked appointmentBooked);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
