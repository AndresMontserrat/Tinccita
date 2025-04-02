namespace Tinccita.Application.DTOs.AppointmentAvailable
{
    public class AppointmentAvailableBase
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time_Start { get; set; }
        public TimeOnly Time_End { get; set; }
        public Guid? ServiceId { get; set; }
    }
}
