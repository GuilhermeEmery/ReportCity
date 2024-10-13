using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Services
{
    public class AuthService : IAuthService
    {
        // Simula Users Diferentes
        private List<User> _users = new List<User>
                {
                    new User { UserId = 1, Username = "operador01", Password = "pass123", Role = "operador" },
                    new User { UserId = 2, Username = "analista01", Password = "pass123", Role = "analista" },
                    new User { UserId = 3, Username = "gerente01", Password = "pass123", Role = "gerente" },
                    new User { UserId = 4, Username = "operador02", Password = "pass123", Role = "operador" },
                    new User { UserId = 5, Username = "analista02", Password = "pass123", Role = "analista" },
                    new User { UserId = 6, Username = "gerente02", Password = "pass123", Role = "gerente" },
                    new User { UserId = 7, Username = "operador03", Password = "pass123", Role = "operador" }
                };
        public User Authenticate(string username, string password)
        {
            // Aqui você normalmente faria a verificação de senha de forma segura
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password) ?? new User();
        }
    }
}