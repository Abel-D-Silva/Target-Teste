using System;
using Questoes;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nQual questão deseja executar (1 a 5)? Digite 0 para sair:");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Questao1.Executar();
                    break;
                case "2":
                    Questao2.Executar();
                    break;
                case "3":
                    Questao3.Executar();
                    break;
                case "4":
                    Questao4.Executar();
                    break;
                case "5":
                    Questao5.Executar();
                    break;
                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
