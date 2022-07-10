using Social_Network.Core.Application.ViewModels.User;
using Social_Network.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Interfaces.Services
{
    public interface IUserService : IGenericService<SaveUserViewModel, UserViewModel, User>
    {
        Task<List<UserViewModel>> GetAllViewModelWithInclude();
        Task<UserViewModel> Login(LoginViewModel loginVm);
        Task<bool> UserExist(string username);
        Task<SaveUserViewModel> GetUserByUserName(string userName);
    }
}
