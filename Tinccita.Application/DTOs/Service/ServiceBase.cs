namespace Tinccita.Application.DTOs.Service
{
    public class ServiceBase
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public Guid? SubcategoryId { get; set; }
    }
}
