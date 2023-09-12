using FluxPlanner.Models;

namespace FluxPlanner.Interfaces.IService
{
    public interface IDeskService
    {
        Task<IEnumerable<Desk>> GetAllDesks();
        Task<Desk> GetDeskById(int deskId);
        Task CreateDesk(Desk desk);
        Task DeleteDesk(int deskId);
    }
}
