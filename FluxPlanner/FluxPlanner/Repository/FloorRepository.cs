using FluxPlanner.Data;
using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FluxPlanner.Repository
{
    public class FloorRepository : IFloorRepository
    {
        private readonly PlannerContext _context;
        public FloorRepository(PlannerContext context)
        {
            _context = context;
        }

        public async Task CreateFloor(Floor floor)
        {
            _context.Floors.Add(floor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFloor(int id)
        {
            if (_context.Floors == null)
            {
                throw new ArgumentNullException("Floor not found");
            }
            var user = await _context.Floors.FindAsync(id);
            if (user == null)
            {
                throw new ArgumentNullException("Floor not found");
            }

            _context.Floors.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<ActionResult<Floor>> GetFloor(int id)
        {
            var floor = await _context.Floors.FindAsync(id) ?? throw new ArgumentNullException("Floor not found");
            return floor;
        }

        public async Task<ActionResult<IEnumerable<Floor>>> GetFloors()
        {
            return await _context.Floors.ToListAsync();
        }
    }
}
