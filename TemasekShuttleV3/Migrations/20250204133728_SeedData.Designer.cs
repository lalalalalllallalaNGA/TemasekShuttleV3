﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TemasekShuttleV3.Data;

#nullable disable

namespace TemasekShuttleV3.Migrations
{
    [DbContext(typeof(TemasekShuttleV3Context))]
    [Migration("20250204133728_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TemasekShuttleV3.Domain.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BusTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleOccurrenceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("TemasekShuttleV3.Domain.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusCapacity")
                        .HasColumnType("int");

                    b.Property<string>("BusPlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScheduleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusCapacity = 40,
                            BusPlate = "SA4B1G3R"
                        },
                        new
                        {
                            Id = 2,
                            BusCapacity = 40,
                            BusPlate = "PM0T7J9D"
                        });
                });

            modelBuilder.Entity("TemasekShuttleV3.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("TemasekShuttleV3.Domain.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DriverContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Driver");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DriverContact = "81234567",
                            DriverName = "Jovan"
                        },
                        new
                        {
                            Id = 2,
                            DriverContact = "91234567",
                            DriverName = "Zoey"
                        },
                        new
                        {
                            Id = 3,
                            DriverContact = "85234891",
                            DriverName = "Yu Feng"
                        },
                        new
                        {
                            Id = 4,
                            DriverContact = "98257845",
                            DriverName = "Triston"
                        });
                });

            modelBuilder.Entity("TemasekShuttleV3.Domain.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("FeedbackContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FeedbackRating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("TemasekShuttleV3.Domain.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<decimal?>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PaymentAmountId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniquePaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("TemasekShuttleV3.Domain.PaymentAmount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("NonpeakPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PeakPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PaymentAmount");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NonpeakPrice = 1.50m,
                            PeakPrice = 2.50m
                        });
                });

            modelBuilder.Entity("TemasekShuttleV3.Domain.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BusScheduleDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BusScheduleTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DriverDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DriverTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ScheduleLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpareDriver")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schedule");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusScheduleDate = new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            BusScheduleTime = new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverDate = new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = 0,
                            DriverTime = new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            ScheduleLocation = "Tampines East MRT Exit C",
                            SpareDriver = ""
                        },
                        new
                        {
                            Id = 2,
                            BusScheduleDate = new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            BusScheduleTime = new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverDate = new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = 0,
                            DriverTime = new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            ScheduleLocation = "Punggol MRT Exit A",
                            SpareDriver = ""
                        });
                });

            modelBuilder.Entity("TemasekShuttleV3.Domain.ScheduleOccurrence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BusScheduleDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BusScheduleTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ScheduleOccurrence");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusScheduleDate = new DateTime(2025, 2, 4, 21, 37, 27, 963, DateTimeKind.Local).AddTicks(6242),
                            BusScheduleTime = new DateTime(2025, 2, 4, 21, 37, 27, 963, DateTimeKind.Local).AddTicks(6254),
                            ScheduleId = 0
                        },
                        new
                        {
                            Id = 2,
                            BusScheduleDate = new DateTime(2025, 2, 4, 21, 37, 27, 963, DateTimeKind.Local).AddTicks(6258),
                            BusScheduleTime = new DateTime(2025, 2, 4, 21, 37, 27, 963, DateTimeKind.Local).AddTicks(6259),
                            ScheduleId = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
