using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;

            // apenas uma casa decimal
            Console.WriteLine(valor.ToString("F1"));

            // com duas casas decimais
            Console.WriteLine(valor.ToString("F2"));

            // currency
            Console.WriteLine(valor.ToString("C"));

            // percentual, porém ele multiplica o valor por 100
            Console.WriteLine(valor.ToString("P"));

            // ainda percentual, então para apresentar os 15.175% o valor deve ser 0,15175, mas ele vai arrendondar para 2 casas decimais
            double value = 0.15175;
            Console.WriteLine(value.ToString("P"));

            // faz a formatação como uma máscara, neste caso para apresentar as 3 casas decimais
            Console.WriteLine(valor.ToString("#.###"));

            // formata a cultura conforme o parâmetro
            CultureInfo cultura = new CultureInfo("pt-BR");

            // formata para currency sem casas decimais
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;

            // completa com zeros a esquerda até o limite informado
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
