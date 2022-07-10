using Microsoft.EntityFrameworkCore;
using Social_Network.Core.Application.Helpers;
using Social_Network.Core.Application.Interfaces.Repositories;
using Social_Network.Core.Application.ViewModels.User;
using Social_Network.Core.Domain.Entities;
using Social_Network.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly Social_NetworkContext _dbContext;
        public UserRepository(Social_NetworkContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        //Method to checking if user already exist
        public async Task<bool> UserExist(string username)
        {
            bool result = await _dbContext.Set<User>().AnyAsync(user => user.UserName.ToLower() == username.ToLower());
            return result;
        }
        public override async Task<User> AddAsync(User entity)
        {
            entity.Password = PasswordEncryption.ComputeSha256Hash(entity.Password);
            return await base.AddAsync(entity);
        }

        public async Task<User> LoginAsync(LoginViewModel vm)
        {
            string passwordEncrypt = PasswordEncryption.ComputeSha256Hash(vm.Password);
            User user = await _dbContext.Set<User>()
                .FirstOrDefaultAsync(user => user.UserName == vm.UserName && user.Password == passwordEncrypt);

            return user;
        }

        //Method to get an entity by userName
        public async Task<User> GetUserByUserName(string userName)
        {
            User user = await _dbContext.Set<User>().SingleOrDefaultAsync(user => user.UserName.ToLower() == userName.ToLower());
            return user;
        }
    }
}
