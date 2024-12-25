using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.AppointmentBooked
{
    public class UpdateAppointmentBooked : AppointmentBookedBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
