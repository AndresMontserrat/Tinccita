using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentBookedCustomer;

namespace Tinccita.Application.Services.Interfaces
{
    public interface IAppointmentBookedCustomerService
    {
        Task<IEnumerable<GetAppointmentBookedCustomer>> GetAllAsync();
        Task<GetAppointmentBookedCustomer> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateAppointmentBookedCustomer appointmentAvailable);
        Task<ServiceResponse> UpdateAsync(UpdateAppointmentBookedCustomer appointmentAvailable);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
