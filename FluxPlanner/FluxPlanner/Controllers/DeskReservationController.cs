using FluxPlanner.Models;
using FluxPlanner.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeskReservationController : ControllerBase
    {
        private readonly ReservationRepository _repository; // You need to create a repository to handle data access.

        public DeskReservationController(ReservationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DeskReservation>> GetReservations()
        {
            var reservations = _repository.GetReservations();
            return Ok(reservations);
        }

        [HttpPost]
        public ActionResult<DeskReservation> CreateReservation(DeskReservation reservation)
        {
            var createdReservation = _repository.CreateReservation(reservation);
            return CreatedAtAction(nameof(GetReservations), new { id = createdReservation.DeskId }, createdReservation);
        }
    }
    }
