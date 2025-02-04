namespace TemasekShuttleV3.Domain
{
    public class ScheduleOccurrence : BaseDomainModel
    {
        public DateTime BusScheduleDate { get; set; }
        public DateTime BusScheduleTime { get; set; }
        public int ScheduleId { get; set; } //FK
    }
}
