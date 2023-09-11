using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;

namespace FluxPlanner.Services
{
    public class DeskService : IDeskService
    {
        public Task<int> CreateDesk(Desk desk)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDesk(int deskId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Desk>> GetAllDesks()
        {
            throw new NotImplementedException();
        }

        public Task<Desk> GetDeskById(int deskId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDesk(Desk desk)
        {
            throw new NotImplementedException();
        }
    }
}
