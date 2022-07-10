using Microsoft.AspNetCore.Mvc;
using Social_Network.Core.Application.Dtos.Email;
using Social_Network.Core.Application.Helpers;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Social_Network.Middlewares;

namespace WebApp.Social_Network.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ValidateUserSession _validateUserSession;
        private readonly IUploadFileService _uploadFileService;
        private readonly IEmailService _emailService;
        public UserController(IUserService userService, IUploadFileService uploadFileService, ValidateUserSession validateUserSession, IEmailService emailService)
        {
            _userService = userService;
            _validateUserSession = validateUserSession;
            _uploadFileService = uploadFileService;
            _emailService = emailService;
        }
        public IActionResult IndexUser()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "Home", Action = "Index" });
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexUser(LoginViewModel loginVm)
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "Home", Action = "Index" });
            }
            if (!ModelState.IsValid)
            {
                return View(loginVm);
            }

            UserViewModel userVm = await _userService.Login(loginVm);

            if (userVm != null)
            {
                if (userVm.IsActive)
                {
                    HttpContext.Session.Set<UserViewModel>("user", userVm);
                    return RedirectToRoute(new { Controller = "Home", Action = "Index" });
                }
                else
                {
                    ModelState.AddModelError("userValidation", "Por favor confirma el correo antes de iniciar sesion");
                }
            }
            else
            {
                ModelState.AddModelError("userValidation", "Datos de acceso incorrectos");
            }
            return View(loginVm);
        }

        public IActionResult Register()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "Home", Action = "Index" });
            }
            return View(new SaveUserViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(SaveUserViewModel userVm)
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "Home", Action = "Index" });
            }
            if (!ModelState.IsValid)
            {
                return View(userVm);
            }
            if (await UserExist(userVm.UserName))
            {
                ModelState.AddModelError("userValidation", "Ese usuario ya existe, por favor indicar otro");
                userVm.UserExit = true;
                return View(userVm);
            }
            SaveUserViewModel savedUser = await _userService.AddSaveViewModel(userVm);
            if (savedUser != null && savedUser.Id != 0)
            {
                string basePath = $"/Images/Users/{savedUser.Id}";
                savedUser.ProfilePictureUrl = _uploadFileService.UploadFile(userVm.ProfilePicture, basePath);

                await _userService.UpdateSaveViewModel(savedUser, savedUser.Id);
            }
            return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
        }
        public async Task<IActionResult> UserVerification(int id)
        {
            if (_validateUserSession.HasUser() || id == 0)
            {
                return RedirectToRoute(new { Controller = "Home", Action = "Index" });
            }
            SaveUserViewModel savedUser = await _userService.GetByIdSaveViewModel(id);
            if (savedUser == null)
            {
                return RedirectToRoute(new { Controller = "Home", Action = "Index" });
            }
            savedUser.IsActive = true;
            await _userService.UpdateSaveViewModel(savedUser, savedUser.Id);
            return View();
        }
        public IActionResult ResetPassword()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "Home", Action = "Index" });
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(string UserName)
        {
            if (await UserExist(UserName))
            {
                Guid guid = Guid.NewGuid();
                SaveUserViewModel userVm = await _userService.GetUserByUserName(UserName);
                userVm.Password = guid.ToString();
                userVm.Password = PasswordEncryption.ComputeSha256Hash(userVm.Password);
                await _userService.UpdateSaveViewModel(userVm, userVm.Id);

                await _emailService.SendAsync(new EmailRequest
                {
                    To = userVm.Email,
                    Subject = "Mensaje de Social Network",
                    Body =
                    $"<h1>Restableciendo su contraseña </h1> <p>Su nueva contraseña es: {guid}</p>" +
                    $"<a href = 'https://localhost:44311/User/IndexUser'>Inicie sesion con su nueva contraseña</a>"
                });
            }
            else
            {
                ModelState.AddModelError("userValidation", "Ese usuario no existe, intenta con otro");
                return View();
            }
            return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("user");
            return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
        }

        private async Task<bool> UserExist(string username)
        {
            bool result = await _userService.UserExist(username);
            return result;
        }
    }
}
