using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    /// <summary>
    /// A set of services grouped by the same characteristics
    /// </summary>
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
