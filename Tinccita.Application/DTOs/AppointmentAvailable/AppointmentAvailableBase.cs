namespace Tinccita.Application.DTOs.AppointmentAvailable
{
    public class AppointmentAvailableBase
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public Guid? ServiceId { get; set; }
    }
}
