using AutoMapper;
using Social_Network.Core.Application.Dtos.Email;
using Social_Network.Core.Application.Interfaces.Repositories;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Application.ViewModels.User;
using Social_Network.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Services
{
    public class UserService : GenericService<SaveUserViewModel, UserViewModel, User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IEmailService emailService, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _emailService = emailService;
            _mapper = mapper;
        }

        //METHODS

        //Method to get all Users
        public async Task<List<UserViewModel>> GetAllViewModelWithInclude()
        {
            var userList = await _userRepository.GetAllWithIncludeAsync(new List<string> { "Publications" });

            return userList.Select(user => new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Password = user.Password

            }).ToList();
        }

        //Method to checking if user already exist
        public async Task<bool> UserExist(string username)
        {
            bool result = await _userRepository.UserExist(username);
            return result;
        }
        //Method Login
        public async Task<UserViewModel> Login(LoginViewModel loginVm)
        {
            User user = await _userRepository.LoginAsync(loginVm);

            if (user == null)
            {
                return null;
            }

            UserViewModel userVm = _mapper.Map<UserViewModel>(user);

            return userVm;
        }
        //Method to add new user
        public override async Task<SaveUserViewModel> AddSaveViewModel(SaveUserViewModel vm)
        {
            SaveUserViewModel savedUser = await base.AddSaveViewModel(vm);

            await _emailService.SendAsync(new EmailRequest
            {
                To = savedUser.Email,
                Subject = "Bienvenido a Social Network",
                Body = 
                $"<h1>Bienvenido a Social Network</h1> <p>Su nombre de usuario es {savedUser.UserName}</p>" +
                $"<a href = 'https://localhost:44311/User/UserVerification/{savedUser.Id}'>Confirmar Correo</a>"
            });
           
            return savedUser;
        }

        //Method to get a user by Username
        public async Task<SaveUserViewModel> GetUserByUserName(string userName)
        {
            User user = await _userRepository.GetUserByUserName(userName);

            SaveUserViewModel userVm = _mapper.Map<SaveUserViewModel>(user);

            return userVm;
        }
    }
}
