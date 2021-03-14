using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MCT_BACKEND4.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;

namespace MCT_BACKEND4.Services
{
    public interface IMailService
    {
        Task SendMail(string from, string to);
    }

    public class MailService : IMailService
    {
        private EmailSettings _emailSettings;

        public MailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public async Task SendMail(string from, string to)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Joey Tribbiani", from));
            message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", to));
            message.Subject = "How you doin'?";

            message.Body = new TextPart("plain")
            {
                Text = @"Beste burger,
                Proficiat met uw vaccin
                -- België"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_emailSettings.MailServer, 25, false);

                // Note: only needed if the SMTP server requires authentication
                // await client.AuthenticateAsync ("joey", "password");

                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
