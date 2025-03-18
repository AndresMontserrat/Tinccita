namespace Tinccita.Application.DTOs.AppointmentBooked
{
    public class AppointmentBookedBase
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time_Start { get; set; }
        public TimeOnly Time_End { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? ServiceId { get; set; }
    }
}
