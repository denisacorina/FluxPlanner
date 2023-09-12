using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesksController : ControllerBase
    {
        private readonly IDeskService _deskService;

        public DesksController(IDeskService deskService)
        {
            _deskService = deskService;
        }

        [HttpGet("getAllAvailableDesks/{startDate}/{endDate}")]
        public Task<IEnumerable<Desk>> GetAllAvailableDesks(DateTime startDate, DateTime endDate)
        {
            return _deskService.GetAllAvailableDesks(startDate, endDate);
        }

        [HttpGet("getAvailableDesksByRoom/{startDate}/{endDate}/{roomId}")]
        public Task<IEnumerable<Desk>> GetAvailableDesksByRoom(DateTime startDate, DateTime endDate, int roomId)
        {
            return _deskService.GetAvailableDesksByRoom(startDate, endDate, roomId);
        }

        [HttpGet("getDesksByRoom/{roomId}")]
        public Task<IEnumerable<Desk>> GetDesksByRoom(int roomId)
        {
            return _deskService.GetDesksByRoom(roomId);
        }
    }
}
