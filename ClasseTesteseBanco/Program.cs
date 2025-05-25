using System;

namespace ProjetoLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginService = new LoginService();

            Console.WriteLine("=== Sistema de Login ===");

            Console.Write("Digite o nome de usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            bool loginValido = loginService.ValidarLogin(nome, senha);

            if (loginValido)
            {
                Console.WriteLine("Login realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("U/suário ou senha inválidos.");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
