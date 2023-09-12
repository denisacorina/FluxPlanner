using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorsController : ControllerBase
    {
        private readonly IFloorService _floorService;

        public FloorsController(IFloorService floorService)
        {
            _floorService = floorService;
        }

        // GET: api/Floors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Floor>>> GetFloors()
        {
            return await _floorService.GetFloors();
        }

        // GET: api/Floors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Floor>> GetFloor(int id)
        {
            var floor = await _floorService.GetFloor(id);
            return floor;
        }

        // POST: api/Floors
        [HttpPost]
        public async Task<ActionResult<Floor>> CreateFloor(Floor floor)
        {
            await _floorService.CreateFloor(floor);
            return CreatedAtAction("GetFloor", new { id = floor.FloorId }, floor);
        }

        // DELETE: api/Floors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFloor(int id)
        { 
            await _floorService.DeleteFloor(id);   
            return NoContent();
        }
    }
}
