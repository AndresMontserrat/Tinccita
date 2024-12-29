using System.ComponentModel.DataAnnotations;

namespace Tinccita.Application.DTOs.Service
{
    public class ServiceBase
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public Guid? SubcategoryId { get; set; }
    }
}
