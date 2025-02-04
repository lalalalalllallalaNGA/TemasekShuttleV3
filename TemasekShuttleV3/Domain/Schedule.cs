namespace TemasekShuttleV3.Domain
{
    public class Schedule : BaseDomainModel
    {
        public DateTime BusScheduleDate { get; set; }  // Single date and time for a specific bus schedule
        public DateTime BusScheduleTime { get; set; }
        public string? ScheduleLocation { get; set; }
        public DateTime DriverDate { get; set; }
        public DateTime DriverTime { get; set; }
        public string? SpareDriver { get; set; }
        public int DriverId { get; set; } // FK to Driver
    }
}
