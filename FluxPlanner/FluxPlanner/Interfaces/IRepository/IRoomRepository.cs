using FluxPlanner.Models;

namespace FluxPlanner.Interfaces.IRepository
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAllRooms();
        Task<Room> GetRoomById(int roomId);
        Task<bool> DeleteRoom(int roomId);
        public Task<IEnumerable<Room>> GetRoomsByFloor(int floorId);
    }
}
