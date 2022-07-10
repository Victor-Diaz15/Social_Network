using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Social_Network.Core.Application.Interfaces.Repositories;
using Social_Network.Infrastructure.Persistence.Contexts;
using Social_Network.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection service, IConfiguration config)
        {
            if (config.GetValue<bool>("UseMemoryDatabase"))
            {
                service.AddDbContext<Social_NetworkContext>(options => options.UseInMemoryDatabase("SocialNetworkdb"));
            }
            else
            {
                service.AddDbContext<Social_NetworkContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"), m => m.MigrationsAssembly(typeof(Social_NetworkContext).Assembly.FullName)));
            }

            #region Repositories
            service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddTransient<IUserRepository, UserRepository>();
            service.AddTransient<IPublicationRepository, PublicationRepository>();
            service.AddTransient<ICommentRepository, CommentRepository>();
            service.AddTransient<IFriendRepository, FriendRepository>();
            #endregion
        }
    }
}
