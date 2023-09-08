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
                new { UserId = 1, FirstName = "Test", LastName = "Test", Email = "test@t.com", WorkLocation = "WFH" }
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
