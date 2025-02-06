using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TemasekShuttleV3.Configurations.Entities;
using TemasekShuttleV3.Data;

namespace TemasekShuttleV3.Data
{
    public class TemasekShuttleV3Context(DbContextOptions<TemasekShuttleV3Context> options) : IdentityDbContext<TemasekShuttleV3User>(options)
    {
        public DbSet<TemasekShuttleV3.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<TemasekShuttleV3.Domain.Bus> Bus { get; set; } = default!;
        public DbSet<TemasekShuttleV3.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<TemasekShuttleV3.Domain.Driver> Driver { get; set; } = default!;
        public DbSet<TemasekShuttleV3.Domain.Feedback> Feedback { get; set; } = default!;
        public DbSet<TemasekShuttleV3.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<TemasekShuttleV3.Domain.PaymentAmount> PaymentAmount { get; set; } = default!;
        public DbSet<TemasekShuttleV3.Domain.Schedule> Schedule { get; set; } = default!;
        public DbSet<TemasekShuttleV3.Domain.ScheduleOccurrence> ScheduleOccurrence { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DriverSeed());
            builder.ApplyConfiguration(new BusSeed());
            builder.ApplyConfiguration(new ScheduleSeed());
            builder.ApplyConfiguration(new ScheduleOccurrenceSeed());
            builder.ApplyConfiguration(new PaymentAmountSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());

        }
    }
}
