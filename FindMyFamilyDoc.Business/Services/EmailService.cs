using FindMyFamilyDoc.Business.Interfaces;
using SendGrid.Helpers.Mail;
using SendGrid;
using Microsoft.Extensions.Configuration;

namespace FindMyFamilyDoc.Business.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string plainTextContent, string htmlContent)
        {
            var apiKey = _configuration.GetValue<string>("SendGrid:ApiKey");
            var senderEmail = _configuration.GetValue<string>("SendGrid:SenderEmail");
            var senderName = _configuration.GetValue<string>("SendGrid:SenderName");

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(senderEmail, senderName);
            var to = new EmailAddress(email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            await client.SendEmailAsync(msg);
        }
    }
}