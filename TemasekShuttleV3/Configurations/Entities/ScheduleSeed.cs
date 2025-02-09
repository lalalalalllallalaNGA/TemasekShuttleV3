using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemasekShuttleV3.Domain;

namespace TemasekShuttleV3.Configurations.Entities
{
    public class ScheduleSeed : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasData(
                  new Schedule
                  {
                      Id = 1,
                      ScheduleLocation = "Tampines East MRT Exit C",
                      BusScheduleDate = new DateOnly(2025, 8, 18),
                      BusScheduleTime = new TimeOnly(08, 00, 0),
                      DriverDate = new DateOnly(2025, 8, 18),
                      DriverTime = new TimeOnly(08, 00, 0),
                      SpareDriver = null,
                      DriverId = 1

                  },
                  new Schedule
                  {
                      Id = 2,
                      ScheduleLocation = "Punggol MRT Exit A",
                      BusScheduleDate = new DateOnly(2025, 8, 18),
                      BusScheduleTime = new TimeOnly(08, 00, 0),
                      DriverDate = new DateOnly(2025, 8, 18),
                      DriverTime = new TimeOnly(08, 00, 0),
                      SpareDriver = null,
                      DriverId = 2
                  }

             );
        }
    }
}

