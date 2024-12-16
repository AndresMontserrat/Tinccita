namespace Tinccita.Domain.Entities
{
    public class Service
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
