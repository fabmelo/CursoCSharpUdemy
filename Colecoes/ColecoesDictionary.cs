using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                // se não existir causa um erro
                Console.WriteLine("2004: " + filmes[2004]);

                // se não existir apenas mostra a string vazia e não causa erro
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            // verifica se existe
            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            // remove item
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            // pega o valor
            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            // percorre só a chave
            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            // percorre só valor
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            // percorre chave e valor de for explicita
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            // percorre chave e valor de forma implicita usando inferência de tipo
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
