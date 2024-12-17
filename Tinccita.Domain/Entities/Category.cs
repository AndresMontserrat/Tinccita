using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? BusinessId { get; set; }
        public Business? Business { get; set; }
        public ICollection<Subcategory>? Subcategories { get; set; }
    }
}
