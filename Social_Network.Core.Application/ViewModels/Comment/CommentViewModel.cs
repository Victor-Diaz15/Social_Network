using Social_Network.Core.Application.ViewModels.Publication;
using Social_Network.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.ViewModels.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int PostId { get; set; }
        public PublicationViewModel Post { get; set; }
        public int UserId { get; set; }
        public string PhotoUserUrl { get; set; }
        public UserViewModel User { get; set; }
        public DateTime Created { get; set; }
    }
}
