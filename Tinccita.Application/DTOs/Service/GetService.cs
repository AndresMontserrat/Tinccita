﻿using Tinccita.Application.DTOs.AppointmentAvailable;
using Tinccita.Application.DTOs.AppointmentBooked;

namespace Tinccita.Application.DTOs.Service
{
    public class GetService : ServiceBase
    {
        public Guid Id { get; set; }
        public ICollection<GetAppointmentAvailable>? AppointmentsAvailable {  get; set; }
        public ICollection<GetAppointmentBooked>? AppointmentsBooked {  get; set; }
    }
}