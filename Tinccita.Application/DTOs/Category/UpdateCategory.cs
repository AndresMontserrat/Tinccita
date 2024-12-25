using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.Category
{
    public class UpdateCategory : CategoryBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
