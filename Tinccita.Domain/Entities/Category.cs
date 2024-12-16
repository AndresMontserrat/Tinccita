namespace Tinccita.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public required string Nombre { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
