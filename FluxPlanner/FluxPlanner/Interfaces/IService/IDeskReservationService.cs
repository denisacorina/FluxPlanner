using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Interfaces.IService
{
    public interface IDeskReservationService
    {
        public Task<ActionResult<IEnumerable<DeskReservation>>> GetReservations();
        public Task<DeskReservation> CreateDeskReservation(DeskReservation reservation);
    }
}
