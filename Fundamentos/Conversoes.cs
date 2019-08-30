using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            // é feita a conversão sem necessidade de ser explicita, pois o double é maior que int
            Console.WriteLine("Quebrado: " + quebrado);

            // não é possível fazer a conversão implicita de double para int e foi necessário fazer o cast de double para de forma explicita
            // neste caso vai haver a perda da casa decimal
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            
            // desta forma se for data entrada de um texto ao invés de um número não será possível realizar o parse para int e haverá um bug
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida {0}:", idadeInteiro);
            
            // outra forma de fazer a conversão seria esta, porém o mesmo bug vai ocorrer se digitar um texto e tentar fazer a conversão para inteiro
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Idade inserida {0}:", idadeInteiro);

            // uma forma de TENTAR fazer o parse de string para int, mesmo que digite um texto é o seguinte
            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1; 
            // ele recebe palavra e TENTA enviar para o int, se não conseguir ele passa o valor ZERO, mas não causa um bug
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado do primeiro número: {0}", numero1);

            // código igual ao de cima, porém otimizado
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado do segundo número: {0}", numero2);
        }
    }
}
