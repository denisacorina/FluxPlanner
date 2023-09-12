using FluxPlanner.Data;
using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FluxPlanner.Repository
{
    public class DeskReservationRepository : IDeskReservationRepository
    {
        private readonly PlannerContext _context;

        public DeskReservationRepository(PlannerContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<DeskReservation>>> GetReservations()
        {
            return await _context.DeskReservations.ToListAsync();
        }

        public async Task CreateDeskReservation(DeskReservation reservation)
        {
            _context.DeskReservations.Add(reservation);
            await _context.SaveChangesAsync();
        }

        public bool IsDeskAvailableForReservation(int deskId, DateTime startDate, DateTime endDate)
        {
            var deskAvailable = _context.DeskReservations
                .Any(r => r.DeskId == deskId &&
                r.ReservationStatus == ReservationStatus.Reserved &&
                !(r.EndDate <= startDate || r.StartDate >= endDate) || (r.StartDate <= startDate && r.EndDate >= endDate));

            return !deskAvailable;
        }
    }
}