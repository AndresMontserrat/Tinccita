using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentAvailable;

namespace Tinccita.Application.Services.Interfaces
{
    public interface IAppointmentAvailableService
    {
        Task<ServiceResponse> AddAsync(CreateAppointmentAvailable appointmentAvailable);
        Task<ServiceResponse> UpdateAsync(UpdateAppointmentAvailable appointmentAvailable);
        Task<ServiceResponse> DeleteAsync(Guid id);
        Task<IEnumerable<GetAppointmentAvailable>> GetAllByService(Guid id);
    }
}
