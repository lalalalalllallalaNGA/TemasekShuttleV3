namespace TemasekShuttleV3.Domain
{
    public class Schedule : BaseDomainModel
    {
        public DateOnly BusScheduleDate { get; set; }  // Single date and time for a specific bus schedule
        public TimeOnly BusScheduleTime { get; set; }
        public string? ScheduleLocation { get; set; }
        public DateOnly DriverDate { get; set; }
        public TimeOnly DriverTime { get; set; }
        public string? SpareDriver { get; set; }
        public int DriverId { get; set; } // FK to Driver
    }
}
