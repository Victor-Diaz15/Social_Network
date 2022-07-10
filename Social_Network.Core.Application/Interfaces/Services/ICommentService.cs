using Social_Network.Core.Application.ViewModels.Comment;
using Social_Network.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Interfaces.Services
{
    public interface ICommentService : IGenericService<SaveCommentViewModel, CommentViewModel, Comment>
    {
        Task<List<CommentViewModel>> GetAllViewModelWithInclude(int postId);
    }
}
