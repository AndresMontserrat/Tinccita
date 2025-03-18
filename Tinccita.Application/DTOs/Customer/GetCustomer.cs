using System.ComponentModel.DataAnnotations;
using Tinccita.Application.DTOs.AppointmentBookedCustomer;

namespace Tinccita.Application.DTOs.Customer
{
    public class GetCustomer : CustomerBase
    {
        [Required]
        public Guid Id { get; set; }
        public ICollection<GetAppointmentBookedCustomer>? Appointments { get; set; }
    }
}