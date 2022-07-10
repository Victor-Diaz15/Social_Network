using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.ViewModels.Comment
{
    public class SaveCommentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tiene que indicar un comentario")]
        public string CommentText { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
    }
}
