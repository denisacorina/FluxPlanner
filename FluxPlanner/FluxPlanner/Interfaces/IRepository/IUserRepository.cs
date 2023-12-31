﻿using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Interfaces.IRepository
{
    public interface IUserRepository
    {
        public Task<ActionResult<IEnumerable<User>>> GetUsers();
        public Task<ActionResult<User>> GetUser(int id);
        public Task CreateUser(User user);
        public Task DeleteUser(int id);
    }
}
