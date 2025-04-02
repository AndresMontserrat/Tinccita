using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.Customer
{
    public class CustomerBase
    {
        [EmailAddress(ErrorMessage = "Email format is wrong; please check if it is properly spelled")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Phone format is wrong; please check it contains just 9 digits")]
        [MaxLength(9, ErrorMessage = "Phone should have 9 numbers")]
        [MinLength(9, ErrorMessage = "Phone should have 9 numbers")]
        public string? Phone { get; set; }
        public string? Name { get; set; }
        public string? Surname1 { get; set; }
        public string? Surname2 { get; set; }
        public string? Address { get; set; }
        [MaxLength(5, ErrorMessage = "Postcode should only have 5 digits")]
        [MinLength(5, ErrorMessage = "Postcode should only have 5 digits")]
        public string? Postcode { get; set; }
        public string? City { get; set; }
    }
}
