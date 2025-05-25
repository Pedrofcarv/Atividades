using System;
using System.Text.RegularExpressions;

class Usuario
{
    public string Nome { get; set; }
    public string Senha { get; set; }

    public Usuario (string nome,  string senha)
    {
        Nome = nome;
        Senha = senha;
    }
}

class Program
{
    static void Main()
    {
        string nomeuser = "";
        string senha = "";
        Usuario usuario = new Usuario(nomeuser, senha);

        Console.WriteLine("=== Cadastro de Usuário ===");
        
        // Nome
        while (true)
        {
            Console.Write("Digite o nome do usuário: ");
            nomeuser = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nomeuser))
            {
                usuario.Nome = nomeuser;
                break;
            }
            else
            {
                Console.WriteLine("O nome não pode ser vazio ou nulo.");
            }
        }

        // Senha
        while (true)
        {
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();

            if (ValidarSenha(senha))
            {
                usuario.Senha = senha;
                break;
            }
            else
            {
                Console.WriteLine("A senha deve ter no mínimo 6 caracteres e conter pelo menos uma letra maiúscula.");
            }
        }

        Console.WriteLine("\nUsuário cadastrado com sucesso!");
        Console.WriteLine($"Nome: {usuario.Nome}");
    }

    static bool ValidarSenha(string senha)
    {
        if (senha.Length < 6)
            return false;

        // Verifica se há pelo menos uma letra maiúscula
        if (!Regex.IsMatch(senha, @"[A-Z]"))
            return false;

        return true;
    }
}

