namespace TemasekShuttleV3.Domain
{
    public class ScheduleOccurrence : BaseDomainModel
    {
        public DateOnly BusScheduleDate { get; set; }
        public TimeOnly BusScheduleTime { get; set; }
        public int ScheduleId { get; set; } //FK
    }
}
