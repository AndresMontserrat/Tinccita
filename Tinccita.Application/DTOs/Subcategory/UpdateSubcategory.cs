using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.Subcategory
{
    public class UpdateSubcategory : SubcategoryBase 
    {
        [Required]
        public Guid Id { get; set; }
    }
}
