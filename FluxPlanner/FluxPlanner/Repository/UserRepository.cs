using FluxPlanner.Data;
using FluxPlanner.Interfaces;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FluxPlanner.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PlannerContext _context;
        public UserRepository(PlannerContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id) ?? throw new ArgumentNullException("User not found");
            return user;
        }

        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync(); 
        }

        public async Task DeleteUser(int id)
        {
            if (_context.Users == null)
            {
                throw new ArgumentNullException("User not found");
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                throw new ArgumentNullException("User not found");
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}