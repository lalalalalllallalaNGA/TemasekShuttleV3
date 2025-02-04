using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemasekShuttleV3.Domain;

namespace TemasekShuttleV3.Configurations.Entities
{
    public class PaymentAmountSeed : IEntityTypeConfiguration<PaymentAmount>
    {
        public void Configure(EntityTypeBuilder<PaymentAmount> builder)
        {
            builder.HasData(
                 new PaymentAmount
                 {
                     Id = 1,
                     PeakPrice = 2.50m,
                     NonpeakPrice = 1.50m
                 }

            );
        }
    }
}
