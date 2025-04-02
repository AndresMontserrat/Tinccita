using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.Service
{
    public class UpdateService : ServiceBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
