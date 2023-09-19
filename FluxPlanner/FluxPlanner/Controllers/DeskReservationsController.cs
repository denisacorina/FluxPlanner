using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

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
            
            //Check if the user already has a reservation
            var existingReservation = await _deskReservationService.GetReservationByUserId(reservation.UserId);

            if (existingReservation != null)
            {
                return BadRequest("User already has a reserved desk.");
            }

            // Create a new reservation
            var createdReservation = await _deskReservationService.CreateDeskReservation(reservation);
            return CreatedAtAction(nameof(GetReservations), new { id = createdReservation.ReservationId }, createdReservation);
        }
    }
    }
    
