using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.Customer
{
    public class UpdateCustomer : CustomerBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
