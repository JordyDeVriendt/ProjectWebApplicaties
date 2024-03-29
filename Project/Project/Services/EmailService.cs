﻿using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Project.Services
{
    public class EmailService : IEmailService
    {
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;
        public EmailService(string host, int port, bool enableSSL, string userName, string password)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSSL;
            this.userName = userName;
            this.password = password;
        }

        public Task SendEmailAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task SendEmailASync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = enableSSL,
            };
            return client.SendMailAsync(
                new MailMessage(userName, email, subject, htmlMessage) { IsBodyHtml = true }

            );
        }
    }
}
