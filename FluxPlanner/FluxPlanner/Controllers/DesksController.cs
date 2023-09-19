using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesksController : Controller
    {

        private readonly IDeskService _deskService;

        public DesksController(IDeskService deskService)
        {
            _deskService = deskService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Desk>>> GetDesks()
        {
            var desks = await _deskService.GetAllDesks();
            return Ok(desks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Desk>> GetDesk(int id)
        {
            var desk = await _deskService.GetDeskById(id);

            if (desk == null)
            {
                return NotFound();
            }

            return Ok(desk);
        }

        [HttpPost]
        public async Task<ActionResult<Desk>> CreateDesk(Desk desk)
        {
            if (desk == null)
        {
                return BadRequest();
            }
            await _deskService.CreateDesk(desk);
     
            return CreatedAtAction(nameof(GetDesk), new { id = desk.DeskId }, desk);
        }

      

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDesk(int id)
        {
            await _deskService.DeleteDesk(id);
            return NoContent();
        }
    }
}
