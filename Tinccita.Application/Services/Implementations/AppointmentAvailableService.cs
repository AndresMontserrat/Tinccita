﻿using AutoMapper;
using Tinccita.Application.DTOs;
using Tinccita.Application.DTOs.AppointmentAvailable;
using Tinccita.Application.Services.Interfaces;
using Tinccita.Domain.Entities;
using Tinccita.Domain.Interfaces;

namespace Tinccita.Application.Services.Implementations
{
    public class AppointmentAvailableService(IGeneric<AppointmentAvailable> appointmentAvailableInterface, IMapper mapper) : IAppointmentAvailableService
    {
        public async Task<ServiceResponse> AddAsync(CreateAppointmentAvailable appointmentAvailable)
        {
            var mappedData = mapper.Map<AppointmentAvailable>(appointmentAvailable);
            int result = await appointmentAvailableInterface.AddAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment created");
            }
            return new ServiceResponse(false, "Appointment not found");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await appointmentAvailableInterface.DeleteAsync(id);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment deleted");
            }
            return new ServiceResponse(false, "Appointment not found");
        }

        public async Task<IEnumerable<GetAppointmentAvailable>> GetAllAsync()
        {
            var rawData = await appointmentAvailableInterface.GetAllAsync();
            if (!rawData.Any()) return [];

            return mapper.Map<IEnumerable<GetAppointmentAvailable>>(rawData);
        }

        public async Task<GetAppointmentAvailable> GetByIdAsync(Guid id)
        {
            var rawData = await appointmentAvailableInterface.GetByIdAsync(id);
            if (rawData == null) return new GetAppointmentAvailable();

            return mapper.Map<GetAppointmentAvailable>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateAppointmentAvailable appointmentAvailable)
        {
            var mappedData = mapper.Map<AppointmentAvailable>(appointmentAvailable);
            int result = await appointmentAvailableInterface.UpdateAsync(mappedData);
            if (result > 0)
            {
                return new ServiceResponse(true, "Appointment updated");
            }
            return new ServiceResponse(false, "Appointment not found");
        }
    }
}
