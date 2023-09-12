﻿// <auto-generated />
using System;
using FluxPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FluxPlanner.Migrations
{
    [DbContext(typeof(PlannerContext))]
    [Migration("20230912130700_CreatedDatabaseAgain")]
    partial class CreatedDatabaseAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FluxPlanner.Models.Desk", b =>
                {
                    b.Property<int>("DeskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeskId"), 1L, 1);

                    b.Property<bool>("IsDeskAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("DeskId");

                    b.HasIndex("RoomId");

                    b.ToTable("Desks");

                    b.HasData(
                        new
                        {
                            DeskId = 1,
                            IsDeskAvailable = true,
                            RoomId = 1
                        },
                        new
                        {
                            DeskId = 2,
                            IsDeskAvailable = true,
                            RoomId = 1
                        },
                        new
                        {
                            DeskId = 3,
                            IsDeskAvailable = true,
                            RoomId = 1
                        },
                        new
                        {
                            DeskId = 4,
                            IsDeskAvailable = true,
                            RoomId = 1
                        },
                        new
                        {
                            DeskId = 5,
                            IsDeskAvailable = true,
                            RoomId = 2
                        },
                        new
                        {
                            DeskId = 6,
                            IsDeskAvailable = true,
                            RoomId = 3
                        },
                        new
                        {
                            DeskId = 7,
                            IsDeskAvailable = true,
                            RoomId = 4
                        },
                        new
                        {
                            DeskId = 8,
                            IsDeskAvailable = true,
                            RoomId = 4
                        });
                });

            modelBuilder.Entity("FluxPlanner.Models.DeskReservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<int>("DeskId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.ToTable("DeskReservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            DeskId = 1,
                            EndDate = new DateTime(2023, 9, 12, 13, 6, 59, 955, DateTimeKind.Utc).AddTicks(566),
                            ReservationStatus = 0,
                            StartDate = new DateTime(2023, 9, 12, 13, 6, 59, 955, DateTimeKind.Utc).AddTicks(564),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("FluxPlanner.Models.Floor", b =>
                {
                    b.Property<int>("FloorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FloorId"), 1L, 1);

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.HasKey("FloorId");

                    b.ToTable("Floors");

                    b.HasData(
                        new
                        {
                            FloorId = 1,
                            FloorNumber = 1
                        },
                        new
                        {
                            FloorId = 2,
                            FloorNumber = 2
                        },
                        new
                        {
                            FloorId = 3,
                            FloorNumber = 3
                        },
                        new
                        {
                            FloorId = 4,
                            FloorNumber = 4
                        });
                });

            modelBuilder.Entity("FluxPlanner.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<int>("AvailableDesks")
                        .HasColumnType("int");

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalDesks")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.HasIndex("FloorId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            AvailableDesks = 30,
                            FloorId = 1,
                            RoomName = "ADV D TLS",
                            TotalDesks = 30
                        },
                        new
                        {
                            RoomId = 2,
                            AvailableDesks = 20,
                            FloorId = 1,
                            RoomName = "ADV D PAD",
                            TotalDesks = 20
                        },
                        new
                        {
                            RoomId = 3,
                            AvailableDesks = 30,
                            FloorId = 2,
                            RoomName = "ADV D ADC",
                            TotalDesks = 30
                        },
                        new
                        {
                            RoomId = 4,
                            AvailableDesks = 10,
                            FloorId = 3,
                            RoomName = "ADV D FRS",
                            TotalDesks = 10
                        },
                        new
                        {
                            RoomId = 5,
                            AvailableDesks = 30,
                            FloorId = 4,
                            RoomName = "ADV D JRD",
                            TotalDesks = 30
                        });
                });

            modelBuilder.Entity("FluxPlanner.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WorkFromOffice")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "test1@t.com",
                            FirstName = "Test1",
                            LastName = "Test1",
                            WorkFromOffice = true
                        },
                        new
                        {
                            UserId = 2,
                            Email = "test2@t.com",
                            FirstName = "Test2",
                            LastName = "Test2",
                            WorkFromOffice = true
                        },
                        new
                        {
                            UserId = 3,
                            Email = "test3@t.com",
                            FirstName = "Test3",
                            LastName = "Test3",
                            WorkFromOffice = false
                        });
                });

            modelBuilder.Entity("FluxPlanner.Models.Desk", b =>
                {
                    b.HasOne("FluxPlanner.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("FluxPlanner.Models.Room", b =>
                {
                    b.HasOne("FluxPlanner.Models.Floor", "Floor")
                        .WithMany()
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Floor");
                });
#pragma warning restore 612, 618
        }
    }
}
