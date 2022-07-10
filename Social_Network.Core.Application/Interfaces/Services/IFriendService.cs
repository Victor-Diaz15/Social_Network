
using Social_Network.Core.Application.ViewModels.Friend;
using Social_Network.Core.Application.ViewModels.Publication;
using Social_Network.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Interfaces.Services
{
    public interface IFriendService : IGenericService<SaveFriendViewModel, FriendViewModel, Friend>
    {
        Task<List<FriendViewModel>> GetAllViewModelWithInclude();
        Task<List<PublicationViewModel>> GetAllFriendPublications();
    }
}
