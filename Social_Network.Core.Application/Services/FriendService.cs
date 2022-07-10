using AutoMapper;
using Microsoft.AspNetCore.Http;
using Social_Network.Core.Application.Helpers;
using Social_Network.Core.Application.Interfaces.Repositories;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Application.ViewModels.Comment;
using Social_Network.Core.Application.ViewModels.Friend;
using Social_Network.Core.Application.ViewModels.Publication;
using Social_Network.Core.Application.ViewModels.User;
using Social_Network.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Services
{
    public class FriendService : GenericService<SaveFriendViewModel, FriendViewModel, Friend>, IFriendService
    {
        private readonly IFriendRepository _friendRepository;
        private readonly IPublicationRepository _publicationRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userVm;
        private readonly IMapper _mapper;
        public FriendService(IFriendRepository friendRepository, IPublicationRepository publicationRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(friendRepository, mapper)
        {
            _friendRepository = friendRepository;
            _publicationRepository = publicationRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userVm = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        //METHODS

        //Method to get all Friends
        public async Task<List<FriendViewModel>> GetAllViewModelWithInclude()
        {
            var friendList = await _friendRepository.GetAllWithIncludeAsync(new List<string> { "User", });

            return friendList.Where(fr => fr.UserId == userVm.Id && fr.UserId != fr.IdFriend).Select(fr => new FriendViewModel
            {
                Id = fr.Id,
                IdFriend = fr.IdFriend,
                UserId = fr.User.Id,
                FriendUserName = fr.User.UserName,
                FriendLastName = fr.User.LastName,
                FriendFirstName = fr.User.FirstName

            }).ToList();
        }

        public async Task<List<PublicationViewModel>> GetAllFriendPublications()
        {
            List<PublicationViewModel> allPostList = new List<PublicationViewModel>();
            PublicationViewModel[] postFriend;
            var PostsList = await _publicationRepository.GetAllWithIncludeAsync(new List<string> { "User" });
            var friendList = await _friendRepository.GetAllWithIncludeAsync(new List<string> { "User", });

            Array idsFriends = friendList.Where(fr => fr.UserId == userVm.Id && fr.UserId != fr.IdFriend).Select(fr => new FriendViewModel
            {
                IdFriend = fr.IdFriend

            }).ToArray();

            foreach (FriendViewModel item in idsFriends)
            {
                postFriend = PostsList.Where(post => post.UserId != userVm.Id && post.UserId == item.IdFriend).OrderByDescending(post => post.Created).Select(post => new PublicationViewModel
                {
                    Id = post.Id,
                    PublicationContent = post.PublicationContent,
                    PhotoPublicationUrl = post.PhotoPublicationUrl,
                    Created = post.Created,
                    UserId = post.User.Id,
                    UserName = post.User.UserName,
                    PhotoUserUrl = post.User.ProfilePictureUrl

                }).ToArray();

                for (int i = 0; i < postFriend.Length; i++)
                {
                    allPostList.Add(postFriend[i]);
                }
                
            }
            return allPostList;
        }
        //Method to add new Friends
        public override async Task<SaveFriendViewModel> AddSaveViewModel(SaveFriendViewModel vm)
        {
            vm.UserId = userVm.Id;
            return await base.AddSaveViewModel(vm);
        }

    }
}
