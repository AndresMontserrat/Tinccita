using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.Business
{
    public class UpdateBusiness : BusinessBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
