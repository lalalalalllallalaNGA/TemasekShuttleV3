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

                    BusScheduleDate = DateTime.Now,

                    BusScheduleTime = DateTime.Now
                },
                new ScheduleOccurrence
                {
                    Id = 2,

                    BusScheduleDate = DateTime.Now,

                    BusScheduleTime = DateTime.Now
                }
            );
        }
    }
}
