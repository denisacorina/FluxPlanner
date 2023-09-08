using FluxPlanner.Data;
using FluxPlanner.Models;

namespace FluxPlanner.Repository
{
    public class ReservationRepository
    {
        private readonly PlannerContext _context;

        public ReservationRepository(PlannerContext context)
        {
            _context = context;
        }

        public IEnumerable<DeskReservation> GetReservations()
        {
            return _context.DeskReservations.ToList();
        }

        public DeskReservation CreateReservation(DeskReservation reservation)
        {
            _context.DeskReservations.Add(reservation);
            _context.SaveChanges();
            return reservation;
        }
    }
}