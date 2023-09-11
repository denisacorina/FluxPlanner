using FluxPlanner.Models;

namespace FluxPlanner.Interfaces.IRepository
{
    public interface IDeskRepository
    {
        Task<IEnumerable<Desk>> GetAllDesks();
        Task<Desk> GetDeskById(int deskId);
        Task<int> CreateDesk(Desk desk);
        Task<bool> UpdateDesk(Desk desk);
        Task<bool> DeleteDesk(int deskId);
    }

}
