using Social_Network.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.ViewModels.Publication
{
    public class PublicationViewModel
    {
        public int Id { get; set; }
        public string PublicationContent { get; set; }
        public string PhotoPublicationUrl { get; set; }
        public DateTime Created { get; set; }
        public string UserName { get; set; }
        public string PhotoUserUrl { get; set; }

        public int UserId { get; set; }
        public UserViewModel User { get; set; }
    }
}
