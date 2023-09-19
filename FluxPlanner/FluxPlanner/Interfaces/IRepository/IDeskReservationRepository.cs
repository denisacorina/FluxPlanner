using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Interfaces.IRepository
{
    public interface IDeskReservationRepository
    {
        public Task<ActionResult<IEnumerable<DeskReservation>>> GetReservations();
        public Task CreateDeskReservation(DeskReservation reservation);
        public bool IsDeskAvailableForReservation(int deskId, DateTime startDate, DateTime endDate);
        public Task<IEnumerable<int>> GetReservedDesks(DateTime startDate, DateTime endDate);
    }
}
