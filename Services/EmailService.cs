using DogMvc.Models.ConfigurationModels;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogMvc.Services
{
    public class EmailService : IEmailSender
    {
        private readonly EmailConfigurationModel _emailSettings;
        public EmailService(IOptions<EmailConfigurationModel> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(string name, string emailFrom, string subject, string htmlMessage)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_emailSettings.Email);
            email.To.Add(MailboxAddress.Parse(_emailSettings.Email));
            email.Subject = subject;

            var body = new BodyBuilder()
            {
                HtmlBody = $"New message from:<br/><br/>" +
                           $"Name: { name }<br/>" +
                           $"Subject: { subject }<br/>" +
                           $"<br/><br/>{ htmlMessage }"
            };

            email.Body = body.ToMessageBody();

            var smtp = ConfigureSmtp();
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }

        private SmtpClient ConfigureSmtp()
        {
            var smtp = new SmtpClient();
            smtp.Connect(_emailSettings.Host, _emailSettings.Port, SecureSocketOptions.StartTlsWhenAvailable);
            smtp.Authenticate(_emailSettings.Email, _emailSettings.Password);

            return smtp;
        }
    }

}

