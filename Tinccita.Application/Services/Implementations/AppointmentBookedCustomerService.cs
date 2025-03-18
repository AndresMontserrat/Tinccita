using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentBookedCustomer;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class AppointmentBookedCustomerService(IGeneric<AppointmentBookedCustomer> appointmentBookedCustomerInterface, IMapper mapper) : IAppointmentBookedCustomerService

    {
        public async Task<ServiceResponse> AddAsync(CreateAppointmentBookedCustomer appointmentBookedCustomer)
        {
            var mappedData = mapper.Map<AppointmentBookedCustomer>(appointmentBookedCustomer);
            int result = await appointmentBookedCustomerInterface.AddAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment created");
            }
            return new ServiceResponse(false, "Appointment not found");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await appointmentBookedCustomerInterface.DeleteAsync(id);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment deleted");
            }
            return new ServiceResponse(false, "Appointment not found");
        }

        public async Task<IEnumerable<GetAppointmentBookedCustomer>> GetAllAsync()
        {
            var rawData = await appointmentBookedCustomerInterface.GetAllAsync();
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetAppointmentBookedCustomer>>(rawData);
        }

        public async Task<GetAppointmentBookedCustomer> GetByIdAsync(Guid id)
        {
            var rawData = await appointmentBookedCustomerInterface.GetByIdAsync(id);
            if (rawData == null) return new GetAppointmentBookedCustomer();

            return mapper.Map<GetAppointmentBookedCustomer>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateAppointmentBookedCustomer appointmentBookedCustomer)
        {
            var mappedData = mapper.Map<AppointmentBookedCustomer>(appointmentBookedCustomer);
            int result = await appointmentBookedCustomerInterface.UpdateAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment updated");
            }
            return new ServiceResponse(false, "Appointment not found");
        }
    }
}
