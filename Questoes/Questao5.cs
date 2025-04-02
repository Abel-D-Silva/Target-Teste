using System;

namespace Questoes
{
    public class Questao5
    {
        public static void Executar()
        {
            Console.Write("Digite uma string para inverter: ");
            string? texto = Console.ReadLine();

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("Texto inválido.");
                return;
            }

            string invertida = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                invertida += texto[i];
            }

            Console.WriteLine($"String invertida: {invertida}");
        }
    }
}
