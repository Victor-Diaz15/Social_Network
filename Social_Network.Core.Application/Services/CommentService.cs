using AutoMapper;
using Microsoft.AspNetCore.Http;
using Social_Network.Core.Application.Helpers;
using Social_Network.Core.Application.Interfaces.Repositories;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Application.ViewModels.Comment;
using Social_Network.Core.Application.ViewModels.User;
using Social_Network.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Services
{
    public class CommentService : GenericService<SaveCommentViewModel, CommentViewModel, Comment>, ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userVm;
        private readonly IMapper _mapper;
        public CommentService(ICommentRepository commentRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(commentRepository, mapper)
        {
            _commentRepository = commentRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userVm = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        //METHODS

        //Method to get all Comments
        public async Task<List<CommentViewModel>> GetAllViewModelWithInclude(int postId)
        {
            var commentList = await _commentRepository.GetAllWithIncludeAsync(new List<string> { "User", "Post" });

            return commentList.Where(comm => comm.PostId== postId).Select(comm => new CommentViewModel
            {
                Id = comm.Id,
                CommentText = comm.CommentText,
                Created = comm.Created,
                UserId = comm.User.Id,
                PostId = comm.Post.Id,
                PhotoUserUrl = comm.User.ProfilePictureUrl

            }).ToList();
        }

        //Method to add new Comment
        public override async Task<SaveCommentViewModel> AddSaveViewModel(SaveCommentViewModel vm)
        {
            vm.UserId = userVm.Id;
            vm.Created = DateTime.Now;
            return await base.AddSaveViewModel(vm);
        }

    }
}
