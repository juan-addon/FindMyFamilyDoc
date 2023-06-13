namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string plainTextContent, string htmlContent);
    }
}
