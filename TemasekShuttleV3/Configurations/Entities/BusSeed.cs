using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemasekShuttleV3.Domain;

namespace TemasekShuttleV3.Configurations.Entities
{
    public class BusSeed : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasData(
                  new Bus
                  {
                      Id = 1,
                      BusPlate = "SA4B1G3R",
                      BusCapacity = 40,

                  },
                  new Bus
                  {
                      Id = 2,
                      BusPlate = "PM0T7J9D",
                      BusCapacity = 40,

                  }
            );

        }
    }
}
