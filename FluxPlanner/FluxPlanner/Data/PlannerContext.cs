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
        }
    }
}
