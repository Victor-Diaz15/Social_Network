using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using Social_Network.Core.Application.Dtos.Email;
using Social_Network.Core.Application.Interfaces.Services;
using Social_Network.Core.Domain.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Infrastructure.Shared.Services
{
    public class EmailService : IEmailService
    {
        private MailSettings _mailSettings { get; }

        public EmailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task SendAsync(EmailRequest req)
        {
            try
            {
                MimeMessage email = new();
                email.Sender = MailboxAddress.Parse($"{_mailSettings.DisplayName} < {_mailSettings.EmailFrom}>");
                email.To.Add(MailboxAddress.Parse(req.To));
                email.Subject = req.Subject;
                BodyBuilder builder = new();
                builder.HtmlBody = req.Body;
                email.Body = builder.ToMessageBody();

                using SmtpClient smtp = new();
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                smtp.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.SmtpUser, _mailSettings.SmtpPass);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch (Exception exp)
            {
            }   

        }
    }
}
