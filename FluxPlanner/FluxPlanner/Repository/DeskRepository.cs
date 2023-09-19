using FluxPlanner.Data;
using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace FluxPlanner.Repository
{
    public class DeskRepository : IDeskRepository
    {
        private readonly PlannerContext _context;
        private readonly IDeskReservationRepository _deskReservationRepository;
        public DeskRepository(PlannerContext context, IDeskReservationRepository deskReservationRepository)
        {
            _context = context;
            _deskReservationRepository = deskReservationRepository;
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

        Task<int> IDeskRepository.CreateDesk(Desk desk)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Desk>> GetDesksByRoom(int roomId)
        {
            return await _context.Desks
                .Where(r => r.RoomId == roomId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Desk>> GetAllAvailableDesks(DateTime startDate, DateTime endDate)
        {
            var reservedDesks = await _deskReservationRepository.GetReservedDesks(startDate, endDate);

            var availableDesks = await _context.Desks
                .Where(d => !reservedDesks.Contains(d.DeskId))
                .ToListAsync();

            return availableDesks;
        }

        public async Task<IEnumerable<Desk>> GetAvailableDesksByRoom(DateTime startDate, DateTime endDate, int roomId)
        {
            var reservedDesks = await _deskReservationRepository.GetReservedDesks(startDate, endDate);

            var availableDesks = await _context.Desks
                .Where(d => !reservedDesks.Contains(d.DeskId) && d.RoomId == roomId)
                .ToListAsync();

            return availableDesks;
        }
    }
}
