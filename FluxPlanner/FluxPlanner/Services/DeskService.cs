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

        public Task<IEnumerable<Desk>> GetAllAvailableDesks(DateTime startDate, DateTime endDate)
        {
            return _deskRepository.GetAllAvailableDesks(startDate, endDate);
        }

        public Task<IEnumerable<Desk>> GetAllDesks()
        {
            return _deskRepository.GetAllDesks();
        }

        public Task<IEnumerable<Desk>> GetAvailableDesksByRoom(DateTime startDate, DateTime endDate, int roomId)
        {
            return _deskRepository.GetAvailableDesksByRoom(startDate, endDate, roomId);
        }

        public Task<Desk> GetDeskById(int deskId)
        {
            return _deskRepository.GetDeskById(deskId);
        }

        public Task<IEnumerable<Desk>> GetDesksByRoom(int roomId)
        {
            return _deskRepository.GetDesksByRoom(roomId);
        }
    }
}
