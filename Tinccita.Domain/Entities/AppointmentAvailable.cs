using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    public class AppointmentAvailable
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public Guid? ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
