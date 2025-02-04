using System.ComponentModel.DataAnnotations;

namespace TemasekShuttleV3.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime BusTime { get; set; }
        public string? BusLocation { get; set; }
        public int CustomerId { get; set; } //FK
        public int ScheduleOccurrenceId { get; set; } //FK
    }
}
