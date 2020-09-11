using System;

namespace aula_entrada_1i3_2020_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDoUsuario;
            string sobrenomeDoUsuario;
            string nomeCompleto;

            Console.Write("Por favor, digite seu nome: ");
            nomeDoUsuario = Console.ReadLine();

            Console.Write("Agora digite seu sobrenome: ");
            sobrenomeDoUsuario = Console.ReadLine();

            nomeCompleto = $"{nomeDoUsuario} {sobrenomeDoUsuario}".ToUpper();

            Console.WriteLine($"Obrigado, {nomeCompleto}! Pressione uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
