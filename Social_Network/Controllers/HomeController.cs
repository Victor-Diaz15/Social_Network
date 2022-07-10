using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Application.ViewModels.Publication;
using Social_Network.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Social_Network.Middlewares;

namespace Social_Network.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPublicationService _publicationService;
        private readonly IUploadFileService _uploadFileService;
        private readonly ValidateUserSession _validateUserSession;
        public HomeController(IPublicationService publicationService, IUploadFileService uploadFileService, ValidateUserSession validateUserSession)
        {
            _publicationService = publicationService;
            _uploadFileService = uploadFileService;
            _validateUserSession = validateUserSession;
        }

        public async Task<IActionResult> Index(SavePublicationViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            ViewBag.Posts = await _publicationService.GetAllViewModelWithInclude();
            if (vm.Id == 0)
            {
                return View(new SavePublicationViewModel());
            }
            return View(vm);
        }
       
        [HttpPost]
        public async Task<IActionResult> AddPost(SavePublicationViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", vm);
            }
            SavePublicationViewModel postVm = await _publicationService.AddSaveViewModel(vm);
            if (postVm != null && postVm.Id != 0)
            {
                string basePath = $"/Images/Publications/{postVm.Id}";

                postVm.PhotoPublicationUrl = _uploadFileService.UploadFile(vm.PhotoPublicationFile, basePath);

                await _publicationService.UpdateSaveViewModel(postVm, postVm.Id);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdatePost(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            SavePublicationViewModel vm = await _publicationService.GetByIdSaveViewModel(id);
            return RedirectToAction("Index", vm);
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePost(SavePublicationViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", vm);
            }

            SavePublicationViewModel postVm = await _publicationService.GetByIdSaveViewModel(vm.Id);
            
            string basePath = $"/Images/Publications/{postVm.Id}";
            vm.PhotoPublicationUrl = _uploadFileService.UploadFile(vm.PhotoPublicationFile, basePath, true, postVm.PhotoPublicationUrl);

            await _publicationService.UpdateSaveViewModel(vm, vm.Id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeletePost(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            return View(await _publicationService.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePost(SavePublicationViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            await _publicationService.DeleteViewModel(vm.Id);

            //get directory path
            string basePath = $"/Images/Publications/{vm.Id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            //Create a folder if not exist
            if (Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new(path);
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo folder in directoryInfo.GetDirectories())
                {
                    folder.Delete(true);
                }

                Directory.Delete(path);
            }
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
