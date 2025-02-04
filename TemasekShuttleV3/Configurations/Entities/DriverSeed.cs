using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemasekShuttleV3.Domain;

namespace TemasekShuttleV3.Configurations.Entities
{
    public class DriverSeed : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasData(
                 new Driver
                 {
                     Id = 1,
                     DriverName = "Jovan",
                     DriverContact = "81234567"
                 },
                 new Driver
                 {
                     Id = 2,
                     DriverName = "Zoey",
                     DriverContact = "91234567"
                 },
                 new Driver
                 {
                     Id = 3,
                     DriverName = "Yu Feng",
                     DriverContact = "85234891"
                 },
                 new Driver
                 {
                     Id = 4,
                     DriverName = "Triston",
                     DriverContact = "98257845"
                 }
            );
        }
    }
}
