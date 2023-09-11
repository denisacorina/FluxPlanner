using FluxPlanner.Models;

namespace FluxPlanner.Interfaces.IService
{
    public interface IDeskService
    {
        Task<IEnumerable<Desk>> GetAllDesks();
        Task<Desk> GetDeskById(int deskId);
        Task<int> CreateDesk(Desk desk);
        Task<bool> UpdateDesk(Desk desk);
        Task<bool> DeleteDesk(int deskId);
    }
}
