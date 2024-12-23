using Tinccita.Application.DTOs.Category;

namespace Tinccita.Application.DTOs.Business
{
    public class GetBusiness : BusinessBase
    {
        public Guid Id { get; set; }
        public ICollection<GetCategory>? Categories { get; set; }
    }
}
