using FluxPlanner.Interfaces;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {  
            _userRepository = userRepository; 
        }

        public async Task CreateUser(User user)
        {
            await _userRepository.CreateUser(user);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteUser(id);
        }

        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _userRepository.GetUser(id);
        }

        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }
    }
}
