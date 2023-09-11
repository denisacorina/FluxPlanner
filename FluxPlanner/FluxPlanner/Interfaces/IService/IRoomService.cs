using FluxPlanner.Models;

namespace FluxPlanner.Interfaces.IService
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetAllRooms();
        Task<Room> GetRoomById(int roomId);
        Task<bool> DeleteRoom(int roomId);
    }
}
