using FluxPlanner.Models;

namespace FluxPlanner.Interfaces.IRepository
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAllRooms();
        Task<Room> GetRoomById(int roomId);
        Task DeleteRoom(int roomId);
    }
}
