using System.ComponentModel.DataAnnotations;
using Tinccita.Application.DTOs.Service;

namespace Tinccita.Application.DTOs.AppointmentAvailable
{
    public class GetAppointmentAvailable : AppointmentAvailableBase
    {
        [Required]
        public Guid Id { get; set; }
        public GetService? Service { get; set; }
    }
}
