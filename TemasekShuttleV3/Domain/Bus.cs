namespace TemasekShuttleV3.Domain
{
    public class Bus : BaseDomainModel
    {
        public string? BusPlate { get; set; }
        public int BusCapacity { get; set; }
        public string? ScheduleId { get; set; } //FK
    }
}
