using FluxPlanner.Models;

namespace FluxPlanner.Interfaces.IRepository
{
    public interface IDeskRepository
    {
        Task<IEnumerable<Desk>> GetAllDesks();
        Task<Desk> GetDeskById(int deskId);
        Task CreateDesk(Desk desk);
        Task DeleteDesk(int deskId);
    }

}
