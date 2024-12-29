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
        public ICollection<AppointmentBookedCustomer>? AppointmentsBooked { get; set; }
        public string? Name { get; set; }
        public string? Surname1 { get; set; }
        public string? Surname2 { get; set; }
        public string? Address { get; set; }
        public string? Postcode { get; set; }
        public string? City { get; set; }
    }
}
