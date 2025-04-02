using System.ComponentModel.DataAnnotations;
using Tinccita.Application.DTOs.Category;
using Tinccita.Application.DTOs.Service;

namespace Tinccita.Application.DTOs.Subcategory
{
    public class GetSubcategory : SubcategoryBase
    {
        [Required]
        public Guid Id { get; set; }
        public GetCategory? GetCategory { get; set; }
        public ICollection<GetService>? Services { get; set; }
    }
}