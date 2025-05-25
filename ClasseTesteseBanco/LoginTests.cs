using Xunit;

namespace ProjetoLogin
{
    public class LoginTests
    {
        [Fact]
        public void LoginValido_DeveRetornarTrue()
        {
            var loginService = new LoginService();
            bool resultado = loginService.ValidarLogin("admin", "Admin123");
            Assert.True(resultado);
        }

        [Fact]
        public void LoginInvalido_DeveRetornarFalse()
        {
            var loginService = new LoginService();
            bool resultado = loginService.ValidarLogin("admin", "senhaErrada");
            Assert.False(resultado);
        }
    }
}
