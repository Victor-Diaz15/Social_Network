using Social_Network.Core.Application.ViewModels.Publication;
using Social_Network.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.ViewModels.Friend
{
    public class SaveFriendViewModel
    {
        public int Id { get; set; }
        public int IdFriend { get; set; }
        public string FriendUserName { get; set; }
        //Navigation Property
        public int UserId { get; set; }
    }
}
