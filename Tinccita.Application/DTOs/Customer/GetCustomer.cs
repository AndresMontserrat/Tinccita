using System.ComponentModel.DataAnnotations;
using Tinccita.Application.DTOs.AppointmentBooked;

namespace Tinccita.Application.DTOs.Customer
{
    public class GetCustomer : CustomerBase
    {
        [Required]
        public Guid Id { get; set; }
        public ICollection<GetAppointmentBooked>? Appointments { get; set; }
    }
}