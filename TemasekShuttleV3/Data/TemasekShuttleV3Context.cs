using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TemasekShuttleV3.Configurations.Entities;
using TemasekShuttleV3.Domain;

namespace TemasekShuttleV3.Data
{
    public class TemasekShuttleV3Context : DbContext
    {
        public TemasekShuttleV3Context (DbContextOptions<TemasekShuttleV3Context> options)
            : base(options)
        {
        }

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

        }
    }

}
