using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    /// <summary>
    /// Relationship between appointment booked and customer(s) 
    /// </summary>
    public class AppointmentBookedCustomer
    {
        [Key]
        public Guid? AppointmentBookedId { get; set; }
        [Key]
        public Guid? CustomerGuid { get; set; }
        public string? Details { get; set; }
    }
}
