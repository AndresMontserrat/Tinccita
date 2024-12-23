using Tinccita.Application.DTOs.Customer;
using Tinccita.Application.DTOs.Service;

namespace Tinccita.Application.DTOs.AppointmentBooked
{
    public class GetAppointmentBooked : AppointmentBookedBase
    {
        public Guid Id { get; set; }
        public GetService? Service { get; set; }
        public ICollection<GetCustomer>? Customers { get; set; }
    }
}