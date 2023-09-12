using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Interfaces.IRepository
{
    public interface IFloorRepository
    {
        public Task<ActionResult<IEnumerable<Floor>>> GetFloors();
        public Task<ActionResult<Floor>> GetFloor(int id);
        public Task CreateFloor(Floor floor);
        public Task DeleteFloor(int id);
    }
}
