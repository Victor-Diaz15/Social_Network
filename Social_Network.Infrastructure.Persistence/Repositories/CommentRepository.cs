using Social_Network.Core.Application.Interfaces.Repositories;
using Social_Network.Core.Domain.Entities;
using Social_Network.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Infrastructure.Persistence.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly Social_NetworkContext _dbContext;
        public CommentRepository(Social_NetworkContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
