using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Services
{
    public interface IAuthService
    {
        User Authenticate(string username, string password);
    }
}