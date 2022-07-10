using Social_Network.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Domain.Entities
{
    public class User : AuditableBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = false;

        //Navigation Property
        public ICollection<Publication> Publications { get; set; }

        //Navigation Property
        public ICollection<Comment> Comments { get; set; }

        //Navigation Property
        public ICollection<Friend> Friends { get; set; }
    }
}
