using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;
using FluxPlanner.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Services
{
    public class FloorService : IFloorService
    {
        private readonly IFloorRepository _floorRepository;

        public FloorService(IFloorRepository floorRepository)
        {
            _floorRepository = floorRepository;
        }

        public async Task CreateFloor(Floor floor)
        {
            await _floorRepository.CreateFloor(floor);
        }

        public async Task DeleteFloor(int id)
        {
            await _floorRepository.DeleteFloor(id); 
        }

        public async Task<ActionResult<Floor>> GetFloor(int id)
        {
            return await _floorRepository.GetFloor(id);
        }

        public async Task<ActionResult<IEnumerable<Floor>>> GetFloors()
        {
            return await _floorRepository.GetFloors();
        }
    }
}
