using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Domain.Settings;
using Social_Network.Infrastructure.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Infrastructure.Shared
{
    //Extension Methods - application of this design pattern Decorator
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection service, IConfiguration config)
        {
            service.Configure<MailSettings>(config.GetSection("MailSettings"));
            service.AddTransient<IEmailService, EmailService>();
            service.AddTransient<IUploadFileService, UploadFileService>();
        }
    }
}
