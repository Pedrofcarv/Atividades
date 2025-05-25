using System.Collections.Generic;
using System.Linq;

namespace ProjetoLogin
{
    public class LoginService
    {
        private readonly List<Usuario> usuariosCadastrados = new List<Usuario>
        {
            new Usuario("admin", "Admin123"),
            new Usuario("joao", "Joao2024")
        };

        public bool ValidarLogin(string nome, string senha)
        {
            return usuariosCadastrados.Any(u =>
                u.Nome == nome && u.Senha == senha);
        }
    }
}
