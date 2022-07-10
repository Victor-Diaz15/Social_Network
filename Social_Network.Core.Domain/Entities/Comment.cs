using Social_Network.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Domain.Entities
{
    public class Comment : AuditableBaseEntity
    {
        public string CommentText { get; set; }

        //Navigation Property
        public int UserId { get; set; }
        public User User { get; set; }

        //Navigation Property
        public int PostId { get; set; }
        public Publication Post { get; set; }
    }
}
