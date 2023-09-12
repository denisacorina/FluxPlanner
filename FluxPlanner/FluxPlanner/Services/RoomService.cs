using FluxPlanner.Interfaces;
using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Models;
using FluxPlanner.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Services
{
    public class RoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task DeleteRoom(int id)
        {
            await _roomRepository.DeleteRoom(id);
        }

        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            return await _roomRepository.GetRoomById(id);
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _roomRepository.GetAllRooms();
        }
    }
}
