using Encapsulamento;
using System;

namespace CursoCSharp.OO
{
    class Encapsulamento
    {
        // ========================================
        // ==================== RELAÇÃO POR HERANÇA
        // ========================================
        public class FilhoNaoReconhecido : SubCelebridade
        {
            public new void MeusAcessos()
            {
                Console.WriteLine("\n========== FihoNaoReconhecido (projeto diferente e relação por herança) ==========");

                Console.WriteLine($" > {InfoPublica}"); // Todos
                Console.WriteLine($" > {CorDoOlho}"); // Herança
                //Console.WriteLine($" > {NumeroCelular}"); // Mesmo projeto (assembly)
                Console.WriteLine($" > {JeitoDeFalar}");  // Herança ou mesmo projeto
                //Console.WriteLine($" > {SegredoFamilia}"); // mesma class ou herança no mesmo projeto (C# >= 7.2)
                //Console.WriteLine($" > {UsaMuitoPhotoshop}"); // private é o padrão somente na mesma classe
            }
        }

        // ========================================
        // ================= RELAÇÃO POR COMPOSIÇÃO
        // ========================================
        public class AmigoDistante
        {
            public readonly SubCelebridade amigo = new SubCelebridade();

            public void MeusAcessos()
            {
                Console.WriteLine("\n========== AmigoDistante (projeto diferente e relação por composição) ==========");

                Console.WriteLine($" > {amigo.InfoPublica}"); // Todos
                //Console.WriteLine($" > {amigo.CorDoOlho}"); // Herança
                //Console.WriteLine($" > {amigo.NumeroCelular}"); // Mesmo projeto (assembly)
                //Console.WriteLine($" > {amigo.JeitoDeFalar}");  // Herança ou mesmo projeto
                //Console.WriteLine($" > {amigo.SegredoFamilia}"); // mesma class ou herança no mesmo projeto (C# >= 7.2)
                //Console.WriteLine($" > {amigo.UsaMuitoPhotoshop}"); // private é o padrão somente na mesma classe
            }
        }

        public static void Executar()
        {
            new SubCelebridade().MeusAcessos(); // está em outro projeto é herdado pelos demais
            new FilhoReconhecido().MeusAcessos(); // está em outro projeto e se relaciona com SubCelebridade por HERANÇA
            new AmigoProximo().MeusAcessos(); // está em outro projeto e se relaciona com SubCelebridade por COMPOSIÇÃO
            new FilhoNaoReconhecido().MeusAcessos(); // está neste projeto e se relaciona com SubCelebridade (que está em outro projeto) por HERANÇA
            new AmigoDistante().MeusAcessos(); // está neste projeto e se relaciona com SubCelebridade(que está em outro projeto) por COMPOSIÇÃO
        }
    }
}
