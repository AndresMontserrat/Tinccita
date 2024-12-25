using System.ComponentModel.DataAnnotations;
using Tinccita.Application.DTOs.Business;
using Tinccita.Application.DTOs.Subcategory;

namespace Tinccita.Application.DTOs.Category
{
    public class GetCategory : CategoryBase
    {
        [Required]
        public Guid Id { get; set; }
        public GetBusiness? Business { get; set; }
        public ICollection<GetSubcategory>? Subcategories { get; set; }
    }
}