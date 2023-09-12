using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeskReservationsController : ControllerBase
    {
        private readonly IDeskReservationService _deskReservationService;

        public DeskReservationsController(IDeskReservationService deskReservationService)
        {
            _deskReservationService = deskReservationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeskReservation>>> GetReservations()
        {
            return await _deskReservationService.GetReservations();
        }

        [HttpPost]
        public async Task<ActionResult<DeskReservation>> CreateReservation(DeskReservation reservation)
        {
            var createdReservation = await _deskReservationService.CreateDeskReservation(reservation);
            return CreatedAtAction(nameof(GetReservations), new { id = createdReservation.ReservationId }, createdReservation);
        }
    }
}
