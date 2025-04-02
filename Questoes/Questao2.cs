using System;

namespace Questoes
{
    public class Questao2
    {
        public static void Executar()
        {
            Console.Write("Informe um número: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int numero))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            int a = 0;
            int b = 1;
            bool pertence = false;

            while (b <= numero)
            {
                if (b == numero)
                {
                    pertence = true;
                    break;
                }

                int temp = b;
                b = a + b;
                a = temp;
            }

            if (numero == 0) pertence = true;

            if (pertence)
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
        }
    }
}
