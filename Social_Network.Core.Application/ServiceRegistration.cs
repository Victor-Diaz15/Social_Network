using Microsoft.Extensions.DependencyInjection;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application
{
    //Extension Methods - application of this design pattern Decorator
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection service)
        {
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            #region Services
            service.AddTransient<IUserService, UserService>();
            service.AddTransient<IPublicationService, PublicationService>();
            service.AddTransient<ICommentService, CommentService>();
            service.AddTransient<IFriendService, FriendService>();
            #endregion
        }
    }
}
