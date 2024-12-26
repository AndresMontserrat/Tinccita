using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentBooked;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class AppointmentBookedService(IGeneric<AppointmentBooked> appointmentBookedInterface, IMapper mapper) : IAppointmentBookedService
    {
        public async Task<ServiceResponse> AddAsync(CreateAppointmentBooked appointmentBooked)
        {
            var mappedData = mapper.Map<AppointmentBooked>(appointmentBooked);
            int result = await appointmentBookedInterface.AddAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment created");
            }
            return new ServiceResponse(false, "Appointment not found");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await appointmentBookedInterface.DeleteAsync(id);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment deleted");
            }
            return new ServiceResponse(false, "Appointment not found");
        }

        public async Task<IEnumerable<GetAppointmentBooked>> GetAllAsync()
        {
            var rawData = await appointmentBookedInterface.GetAllAsync();
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetAppointmentBooked>>(rawData);
        }

        public async Task<GetAppointmentBooked> GetByIdAsync(Guid id)
        {
            var rawData = await appointmentBookedInterface.GetByIdAsync(id);
            if (rawData == null) return new GetAppointmentBooked();

            return mapper.Map<GetAppointmentBooked>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateAppointmentBooked appointmentBooked)
        {
            var mappedData = mapper.Map<AppointmentBooked>(appointmentBooked);
            int result = await appointmentBookedInterface.UpdateAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment updated");
            }
            return new ServiceResponse(false, "Appointment not found");
        }
    }
}
