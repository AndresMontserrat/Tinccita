using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    public class Business
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Service>? Services { get; set; }
    }
}
