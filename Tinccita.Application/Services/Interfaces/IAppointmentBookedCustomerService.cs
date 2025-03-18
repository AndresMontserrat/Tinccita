using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentBookedCustomer;

namespace Tinccita.Application.Services.Interfaces
{
    public interface IAppointmentBookedCustomerService
    {
        Task<ServiceResponse> AddAsync(CreateAppointmentBookedCustomer appointmentAvailable);
        Task<ServiceResponse> UpdateAsync(UpdateAppointmentBookedCustomer appointmentAvailable);
        Task<ServiceResponse> DeleteAsync(Guid id);
        Task<IEnumerable<GetAppointmentBookedCustomer>> GetAllByAppointmentAsync(Guid id);
        Task<IEnumerable<GetAppointmentBookedCustomer>> GetAllByCustomerAsync(Guid id);
    }
}
