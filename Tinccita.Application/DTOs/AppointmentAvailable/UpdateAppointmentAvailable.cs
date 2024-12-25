using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.AppointmentAvailable
{
    public class UpdateAppointmentAvailable : AppointmentAvailableBase 
    {
        [Required]
        public Guid Id { get; set; }
    }
}
