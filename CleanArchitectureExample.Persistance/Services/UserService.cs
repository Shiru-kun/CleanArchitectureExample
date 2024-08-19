using CleanArchitectureExample.Domain.Entities;
using CleanArchitectureExample.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Persistance.Services
{
    public class UserService : IUserService
    {
        private UserContext _userContext; 
        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }
        public void CreateUser(User user)
        {
             user.Id = Guid.NewGuid();
            _userContext.Users.Add(user);
        }
        public async Task<List<User>> GetAll()
        {
             return await Task.FromResult(_userContext.Users.ToList());
        }
    }
}
