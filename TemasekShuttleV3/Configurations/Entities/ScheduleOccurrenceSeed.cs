using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemasekShuttleV3.Domain;

namespace TemasekShuttleV3.Configurations.Entities
{
    public class ScheduleOccurrenceSeed : IEntityTypeConfiguration<ScheduleOccurrence>
    {
        public void Configure(EntityTypeBuilder<ScheduleOccurrence> builder)
        {
            builder.HasData(
                new ScheduleOccurrence
                {
                    Id = 1,

                    BusScheduleDate = new DateOnly(2025, 8, 18),

                    BusScheduleTime = new TimeOnly(08, 00, 00),
                    ScheduleId = 1,
                },
                new ScheduleOccurrence
                {
                    Id = 2,

                    BusScheduleDate = new DateOnly(2025, 8, 18),

                    BusScheduleTime = new TimeOnly(08, 00, 00),
                    ScheduleId = 2,
                }
            );
        }
    }
}
