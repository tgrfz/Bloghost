using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Bloghost.Domain;
using Bloghost.Data;

namespace Bloghost.Services
{
    public class EmailService
    {
        private ApplicationDBContext db;
        public EmailService(ApplicationDBContext context)
        {
            db = context;
        }
        public async Task SendEmailAsync(User user, string subject, string message)
        {
            Admin admin = db.Admins.First();
           
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("admin", admin.Email));
            emailMessage.To.Add(new MailboxAddress(user.UserName, user.Email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync(admin.Email, admin.EmailPassword);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
