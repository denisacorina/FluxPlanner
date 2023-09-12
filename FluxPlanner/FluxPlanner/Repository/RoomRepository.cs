using FluxPlanner.Data;
using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace FluxPlanner.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly PlannerContext _context;

        public RoomRepository(PlannerContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetRoomById(int RoomId)
        {
            return await _context.Rooms.FindAsync(RoomId);
        }
      
        public async Task<bool> DeleteRoom(int RoomId)
        {
            var room = await _context.Rooms.FindAsync(RoomId);
            if (room == null)
            {
                return false;
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Room>> GetRoomsByFloor(int floorId)
        {
            return await _context.Rooms
                .Where(f => f.FloorId == floorId)
                .ToListAsync();
        }
    }
}

