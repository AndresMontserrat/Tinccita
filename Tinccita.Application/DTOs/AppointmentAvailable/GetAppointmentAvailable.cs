using Tinccita.Application.DTOs.Service;

namespace Tinccita.Application.DTOs.AppointmentAvailable
{
    public class GetAppointmentAvailable : AppointmentAvailableBase
    {
        public Guid Id { get; set; }
        public GetService? Service { get; set; }
    }
}
