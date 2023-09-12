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

        public Task<int> CreateDesk(Desk desk)
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

        public async Task<bool> UpdateDesk(Desk desk)
        {
            return await _deskRepository.UpdateDesk(desk);        }

        Task<bool> IDeskService.DeleteDesk(int deskId)
        {
            throw new NotImplementedException();
        }
    }
}
