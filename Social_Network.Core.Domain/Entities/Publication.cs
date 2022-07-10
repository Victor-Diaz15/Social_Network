using Social_Network.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Domain.Entities
{
    public class Publication : AuditableBaseEntity
    {
        public string PublicationContent { get; set; }
        public string PhotoPublicationUrl { get; set; }

        //Navigation Property
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
