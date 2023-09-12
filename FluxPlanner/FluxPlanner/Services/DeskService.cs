using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;

namespace FluxPlanner.Services
{
    public class DeskService : IDeskService
    {
        private readonly IDeskRepository _deskRepository;

        public DeskService(IDeskRepository deskRepository)
        {
            _deskRepository = deskRepository;
        }

        public Task CreateDesk(Desk desk)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteDesk(int deskId)
        {
            await _deskRepository.DeleteDesk(deskId);
        }

        public Task<IEnumerable<Desk>> GetAllDesks()
        {
            return _deskRepository.GetAllDesks();
        }

        public Task<Desk> GetDeskById(int deskId)
        {
            return _deskRepository.GetDeskById(deskId);
        }

    }
}
