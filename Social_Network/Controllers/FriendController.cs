using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Application.ViewModels.Friend;
using Social_Network.Core.Application.ViewModels.User;
using System.Threading.Tasks;
using WebApp.Social_Network.Middlewares;

namespace Social_Network.Controllers
{
    public class FriendController : Controller
    {
        private readonly IFriendService _friendService;
        private readonly IUserService _userService;
        private readonly ValidateUserSession _validateUserSession;
        public FriendController(IFriendService friendService, IUserService userService, ValidateUserSession validateUserSession)
        {
            _friendService = friendService;
            _userService = userService;
            _validateUserSession = validateUserSession;
        }

        public async Task<IActionResult> Index()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            ViewBag.PostsFriends = await _friendService.GetAllFriendPublications();
            return View(await _friendService.GetAllViewModelWithInclude());
        }
        public IActionResult AddFriend()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddFriend(SaveFriendViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            if (!ModelState.IsValid)
            {
                return View("Index", vm);
            }
            if (await _userService.UserExist(vm.FriendUserName))
            {
                SaveUserViewModel userVM = await _userService.GetUserByUserName(vm.FriendUserName);
                vm.IdFriend = userVM.Id;
                await _friendService.AddSaveViewModel(vm);
            }            
            else
            {
                ModelState.AddModelError("userValidation", "Ese usuario no existe, intenta con otro");
                return View();
            }
            return RedirectToRoute(new { Controller = "Friend", Action = "Index" });
        }


        public async Task<IActionResult> DeleteFriend(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            return View(await _friendService.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteFriend(SaveFriendViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            await _friendService.DeleteViewModel(vm.Id);

            return RedirectToRoute(new { controller = "Friend", action = "Index" });
        }
    }
}
