using FluxPlanner.Data;
using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace FluxPlanner.Repository
{
    public class DeskRepository : IDeskRepository
    {
        private readonly PlannerContext _context;
        public DeskRepository(PlannerContext context) {
            _context = context;
        }

        public async Task CreateDesk(Desk desk)
        {
            _context.Desks.Add(desk);
            await _context.SaveChangesAsync();
        }

        public async Task<Desk> GetDeskById(int DeskId)
        {
            return await _context.Desks.FindAsync(DeskId);
        }
        public async Task<IEnumerable<Desk>> GetAllDesks()
        {
            return await _context.Desks.ToListAsync();
        }
        
        //TODO:implement the methods
        

        public Task DeleteDesk(int deskId)
        {
            throw new NotImplementedException();
        }

    }
}
