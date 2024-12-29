using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    public class Subcategory
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Service>? Services { get; set; }
    }
}
