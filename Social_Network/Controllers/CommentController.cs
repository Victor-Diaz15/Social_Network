using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Application.ViewModels.Comment;
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
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly ValidateUserSession _validateUserSession;
        public CommentController(ICommentService commentService, ValidateUserSession validateUserSession)
        {
            _commentService = commentService;
            _validateUserSession = validateUserSession;
        }

        public async Task<IActionResult> Index(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            ViewBag.Comments = await _commentService.GetAllViewModelWithInclude(Id);
            ViewBag.postId = Id;
            return View(new SaveCommentViewModel());
        }
       
        [HttpPost]
        public async Task<IActionResult> AddComment(SaveCommentViewModel vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { Controller = "User", Action = "IndexUser" });
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", vm);
            }
            SaveCommentViewModel commentVm =  await _commentService.AddSaveViewModel(vm);
            return RedirectToAction("Index", routeValues: new { Id =  commentVm.PostId});
        }
    }
}
