using Tinccita.Application.DTOs.AppointmentBooked;
using Tinccita.Application.DTOs.Customer;

namespace Tinccita.Application.DTOs.AppointmentBookedCustomer
{
    public class UpdateAppointmentBookedCustomer : AppointmentBookedCustomerBase
    {
        public GetCustomer? Customers { get; set; }
        public GetAppointmentBooked? AppointmentsBooked { get; set; }
    }
}
