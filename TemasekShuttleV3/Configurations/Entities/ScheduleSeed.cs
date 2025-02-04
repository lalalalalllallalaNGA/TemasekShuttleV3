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
                      BusScheduleDate = new DateTime(2025, 8, 18, 09, 00, 0),
                      BusScheduleTime = new DateTime(2025, 8, 18, 09, 00, 0),
                      DriverDate = new DateTime(2025, 8, 18, 09, 00, 0),
                      DriverTime = new DateTime(2025, 8, 18, 09, 00, 0),
                      SpareDriver = ""

                  },
                  new Schedule
                  {
                      Id = 2,
                      ScheduleLocation = "Punggol MRT Exit A",
                      BusScheduleDate = new DateTime(2025, 8, 18, 09, 00, 0),
                      BusScheduleTime = new DateTime(2025, 8, 18, 09, 00, 0),
                      DriverDate = new DateTime(2025, 8, 18, 09, 00, 0),
                      DriverTime = new DateTime(2025, 8, 18, 09, 00, 0),
                      SpareDriver = ""
                  }

             );
        }
    }
}

