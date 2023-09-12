using FluxPlanner.Interfaces;
using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;
using FluxPlanner.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Services
{
    public class RoomService:IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _roomRepository.GetAllRooms();
        }

        public async Task<Room> GetRoomById(int roomId)
        {
            return await _roomRepository.GetRoomById(roomId);
        }

        public async Task DeleteRoom(int roomId)
        {
            await _roomRepository.DeleteRoom(roomId);
        }

    }
}
