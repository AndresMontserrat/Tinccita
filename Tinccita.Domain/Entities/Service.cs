using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public Guid? SubcategoryId { get; set; }
        public Subcategory? Subcategory { get; set; }
        public ICollection<AppointmentAvailable>? AppointmentsAvailable { get; set; }
        public ICollection<AppointmentBooked>? AppointmentsBooked { get; set; }
    }
}
