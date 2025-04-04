﻿using Tinccita.Domain.Entities;

namespace Tinccita.Domain.Interfaces
{
    public interface IAppointmentAvailable
    {
        Task<int> AddAsync(AppointmentAvailable entity);
        Task<int> UpdateAsync(AppointmentAvailable entity);
        Task<int> DeleteAsync(Guid id);
        Task<IEnumerable<AppointmentAvailable>> GetAllByService(Guid id);
    }
}
