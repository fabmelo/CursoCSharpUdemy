using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var backgroundAnterior = Console.BackgroundColor;
                    var foregroundAnterior = Console.ForegroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Numero encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = backgroundAnterior;
                    Console.ForegroundColor = foregroundAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    var backgroundAnterior = Console.BackgroundColor;
                    var foregroundAnterior = Console.ForegroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                    Console.BackgroundColor = backgroundAnterior;
                    Console.ForegroundColor = foregroundAnterior;
                }
                else
                {
                    var backgroundAnterior = Console.BackgroundColor;
                    var foregroundAnterior = Console.ForegroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                    Console.BackgroundColor = backgroundAnterior;
                    Console.ForegroundColor = foregroundAnterior;
                }
            }
        }
    }
}
