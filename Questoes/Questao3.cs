using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Questoes
{
    public class DiaFaturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    public class Questao3
    {
        public static void Executar()
        {
            string caminhoArquivo = "dados.json";

            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
                return;
            }

            string json = File.ReadAllText(caminhoArquivo);
            List<DiaFaturamento>? dados = JsonConvert.DeserializeObject<List<DiaFaturamento>>(json);

            if (dados == null)
            {
                Console.WriteLine("Erro ao ler os dados.");
                return;
            }

            // Ignorar dias com faturamento = 0
            var diasComFaturamento = dados.Where(d => d.valor > 0).ToList();

            double menor = diasComFaturamento.Min(d => d.valor);
            double maior = diasComFaturamento.Max(d => d.valor);
            double media = diasComFaturamento.Average(d => d.valor);
            int diasAcimaMedia = diasComFaturamento.Count(d => d.valor > media);

            Console.WriteLine($"🔹 Menor valor de faturamento: R$ {menor:N2}");
            Console.WriteLine($"🔹 Maior valor de faturamento: R$ {maior:N2}");
            Console.WriteLine($"🔹 Média de faturamento (ignorando zeros): R$ {media:N2}");
            Console.WriteLine($"🔹 Dias com faturamento acima da média: {diasAcimaMedia}");
        }
    }
}
