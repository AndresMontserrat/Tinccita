using Tinccita.Application.DTOs.AppointmentBookedCustomer;
using Tinccita.Application.DTOs.Service;

namespace Tinccita.Application.DTOs.AppointmentBooked
{
    public class GetAppointmentBooked : AppointmentBookedBase
    {
        public Guid Id { get; set; }
        public GetService? Service { get; set; }
        public ICollection<GetAppointmentBookedCustomer>? Customers { get; set; }
    }
}