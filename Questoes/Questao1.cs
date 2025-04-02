using System;

namespace Questoes
{
    public class Questao1
    {
        public static void Executar()
        {
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine($"O resultado da SOMA é: {SOMA}");
        }
    }
}
