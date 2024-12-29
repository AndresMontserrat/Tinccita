using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    public class AppointmentBooked
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public ICollection<Guid>? CustomersId { get; set; }
        public ICollection<Customer>? Customers { get; set; }
        public Guid? ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
