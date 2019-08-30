using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;
            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço com desconto é {0} ", totalComDesconto.ToString("C"));

            // IMC
            double peso = 103.5;
            double altura = 1.66;
            double imc = peso / Math.Pow(altura, 2); // elevando ao quadrado
            Console.WriteLine($"O IMC é de {imc.ToString("F2")}");

            // número para / impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); // par % 2 RESTO DA DIVISÃO = 0
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2); // impar % 2 RESTO DA DIVISÃO = 1
        }
    }
}
