using FluxPlanner.Data;
using FluxPlanner.Models;

namespace FluxPlanner.Repository
{
    public class UserRepository
    {
        private readonly PlannerContext _context;
        public UserRepository(PlannerContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetReservations()
        {
            return _context.Users.ToList();
        }

        public DeskReservation CreateReservation(User users)
        {
            return null;
        }

    }
}