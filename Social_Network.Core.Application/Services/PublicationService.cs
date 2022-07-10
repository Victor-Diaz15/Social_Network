using AutoMapper;
using Microsoft.AspNetCore.Http;
using Social_Network.Core.Application.Helpers;
using Social_Network.Core.Application.Interfaces.Repositories;
using Social_Network.Core.Application.Interfaces.Services;
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
    public class PublicationService : GenericService<SavePublicationViewModel, PublicationViewModel, Publication>, IPublicationService 
    {
        private readonly IPublicationRepository _publicationRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userVm;
        private readonly IMapper _mapper;
        public PublicationService(IPublicationRepository publicationRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(publicationRepository, mapper)
        {
            _publicationRepository = publicationRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userVm = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        //METHODS

        //Method to get all Publications
        public async Task<List<PublicationViewModel>> GetAllViewModelWithInclude()
        {
            var PublicationList = await _publicationRepository.GetAllWithIncludeAsync(new List<string> { "User" });

            return PublicationList.Where(post => post.UserId == userVm.Id).OrderByDescending(comm => comm.Created).Select(post => new PublicationViewModel
            {
                Id = post.Id,
                PublicationContent = post.PublicationContent,
                PhotoPublicationUrl = post.PhotoPublicationUrl,
                Created = post.Created,
                UserId = post.User.Id,
                UserName = post.User.UserName,
                PhotoUserUrl = post.User.ProfilePictureUrl

            }).ToList();
        }

        //Method to add new publication
        public override async Task<SavePublicationViewModel> AddSaveViewModel(SavePublicationViewModel vm)
        {
            vm.UserId = userVm.Id;
            //vm.Created = DateTime.Now;
            return await base.AddSaveViewModel(vm);
        }

        //Method to update a publication
        public override async Task UpdateSaveViewModel(SavePublicationViewModel vm, int id)
        {
            vm.UserId = userVm.Id;
            //vm.Created = DateTime.Now;
            await base.UpdateSaveViewModel(vm, id);
        }

    }
}
