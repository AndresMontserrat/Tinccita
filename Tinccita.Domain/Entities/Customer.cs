using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    public class Customer
    {
        [Key]
        public Guid Guid { get; set; }
        public string? Email { get; set; }
        public string? Prefix { get; set; }
        public string? Phone { get; set; }
        public ICollection<AppointmentBooked>? AppointmentsBooked { get; set; }
    }
}
