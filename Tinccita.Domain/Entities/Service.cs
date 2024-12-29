using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tinccita.Domain.Entities
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int? Minutes { get; set; }
        public Guid? SubcategoryId { get; set; }
        public Subcategory? Subcategory { get; set; }
        public ICollection<AppointmentAvailable>? AppointmentsAvailable { get; set; }
        public ICollection<AppointmentBooked>? AppointmentsBooked { get; set; }
    }
}
