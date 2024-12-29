using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tinccita.Domain.Entities
{
    public class AppointmentBookedCustomer
    {
        [Key]
        public Guid? AppointmentBookedId { get; set; }
        [Key]
        public Guid? CustomerGuid { get; set; }
        public string? Details { get; set; }
    }
}
