﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veggerby.Greenhouse.Core;

namespace Veggerby.Greenhouse.Core.Migrations
{
    [DbContext(typeof(GreenhouseContext))]
    [Migration("20200507093230_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Veggerby.Greenhouse.Core.Device", b =>
                {
                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeviceId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Veggerby.Greenhouse.Core.Measurement", b =>
                {
                    b.Property<int>("MeasurementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Humidity")
                        .HasColumnType("float");

                    b.Property<double>("Pressure")
                        .HasColumnType("float");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<DateTime>("TimeUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("MeasurementId");

                    b.HasIndex("DeviceId");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("Veggerby.Greenhouse.Core.Measurement", b =>
                {
                    b.HasOne("Veggerby.Greenhouse.Core.Device", "Device")
                        .WithMany("Measurements")
                        .HasForeignKey("DeviceId");
                });
#pragma warning restore 612, 618
        }
    }
}
