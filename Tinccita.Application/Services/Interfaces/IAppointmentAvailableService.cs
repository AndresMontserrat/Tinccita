using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentAvailable;

namespace Tinccita.Application.Services.Interfaces
{
    public interface IAppointmentAvailableService
    {
        Task<IEnumerable<GetAppointmentAvailable>> GetAllAsync();
        Task<GetAppointmentAvailable> GetByIdAsync(int id);
        Task<ServiceResponse> AddAsync(CreateAppointmentAvailable appointmentAvailable);
        Task<ServiceResponse> UpdateAsync(UpdateAppointmentAvailable appointmentAvailable);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
