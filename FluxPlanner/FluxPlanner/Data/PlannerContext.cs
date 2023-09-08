using FluxPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace FluxPlanner.Data
{
    public class PlannerContext : DbContext
    {
        public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<DeskReservation> DeskReservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Desk> Desks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, FirstName = "Test1", LastName = "Test1", Email = "test1@t.com", WorkFromOffice = true },
                new User { UserId = 2, FirstName = "Test2", LastName = "Test2", Email = "test2@t.com", WorkFromOffice = true },
                new User { UserId = 3, FirstName = "Test3", LastName = "Test3", Email = "test3@t.com", WorkFromOffice = false }
            );

            modelBuilder.Entity<Floor>().HasData(
                new Floor { FloorId = 1, FloorNumber = 1 },
                new Floor { FloorId = 2, FloorNumber = 2 },
                new Floor { FloorId = 3, FloorNumber = 3 },
                new Floor { FloorId = 4, FloorNumber = 4 }
            );

            modelBuilder.Entity<Room>().HasData(
               new Room { RoomId = 1, RoomName = "ADV D TLS", TotalDesks = 30, AvailableDesks = 30, FloorId = 1 },
               new Room { RoomId = 2, RoomName = "ADV D PAD", TotalDesks = 20, AvailableDesks = 20, FloorId = 1 },
               new Room { RoomId = 3, RoomName = "ADV D ADC", TotalDesks = 30, AvailableDesks = 30, FloorId = 2 },
               new Room { RoomId = 4, RoomName = "ADV D FRS", TotalDesks = 10, AvailableDesks = 10, FloorId = 3 },
               new Room { RoomId = 5, RoomName = "ADV D JRD", TotalDesks = 30, AvailableDesks = 30, FloorId = 4 }
           );

            modelBuilder.Entity<Desk>().HasData(
               new Desk { DeskId = 1, IsDeskAvailable = true, RoomId = 1 },
               new Desk { DeskId = 2, IsDeskAvailable = true, RoomId = 1 },
               new Desk { DeskId = 3, IsDeskAvailable = true, RoomId = 1 },
               new Desk { DeskId = 4, IsDeskAvailable = true, RoomId = 1 },
               new Desk { DeskId = 5, IsDeskAvailable = true, RoomId = 2 },
               new Desk { DeskId = 6, IsDeskAvailable = true, RoomId = 3 },
               new Desk { DeskId = 7, IsDeskAvailable = true, RoomId = 4 },
               new Desk { DeskId = 8, IsDeskAvailable = true, RoomId = 4 }
           );

            modelBuilder.Entity<DeskReservation>().HasData(
               new DeskReservation { ReservationId = 1, DeskId = 1, UserId = 1, StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, ReservationStatus = ReservationStatus.Reserved }
           );

        }
    }
}
