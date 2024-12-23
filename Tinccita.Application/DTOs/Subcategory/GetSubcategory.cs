using Tinccita.Application.DTOs.Category;
using Tinccita.Application.DTOs.Service;

namespace Tinccita.Application.DTOs.Subcategory
{
    public class GetSubcategory : SubcategoryBase
    {
        public Guid Id { get; set; }
        public GetCategory? GetCategory { get; set; }
        public ICollection<GetService>? Services { get; set; }
    }
}