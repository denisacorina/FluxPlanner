using FluxPlanner.Models;

namespace FluxPlanner.Interfaces.IService
{
    public interface IDeskService
    {
        Task<IEnumerable<Desk>> GetAllDesks();
        Task<Desk> GetDeskById(int deskId);
        public Task<IEnumerable<Desk>> GetDesksByRoom(int roomId);
        public Task<IEnumerable<Desk>> GetAllAvailableDesks(DateTime startDate, DateTime endDate);
        public Task<IEnumerable<Desk>> GetAvailableDesksByRoom(DateTime startDate, DateTime endDate, int roomId);
    }
}
