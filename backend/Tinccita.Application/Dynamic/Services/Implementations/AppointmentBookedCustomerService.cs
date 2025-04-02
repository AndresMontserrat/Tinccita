using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentBookedCustomer;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class AppointmentBookedCustomerService(IAppointmentBookedCustomer appointmentBookedCustomerInterface, IMapper mapper) : IAppointmentBookedCustomerService

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

        public async Task<IEnumerable<GetAppointmentBookedCustomer>> GetAllByAppointmentAsync(Guid id)
        {
            var rawData = await appointmentBookedCustomerInterface.GetAllByAppointment(id);
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetAppointmentBookedCustomer>>(rawData);
        }
        public async Task<IEnumerable<GetAppointmentBookedCustomer>> GetAllByCustomerAsync(Guid id)
        {
            var rawData = await appointmentBookedCustomerInterface.GetAllByCustomer(id);
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetAppointmentBookedCustomer>>(rawData);
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
