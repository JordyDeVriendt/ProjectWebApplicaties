using Project.Models;
using System.Threading.Tasks;

namespace Project.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync();
        Task SendEmailASync(string email, string subject, string htmlMessage);
    }
}
