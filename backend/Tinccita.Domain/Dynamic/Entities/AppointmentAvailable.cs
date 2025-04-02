using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    /// <summary>
    /// Slots available for appointments for services
    /// </summary>
    public class AppointmentAvailable
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time_Start { get; set; }
        public TimeOnly Time_End { get; set; }
        public Guid? ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
