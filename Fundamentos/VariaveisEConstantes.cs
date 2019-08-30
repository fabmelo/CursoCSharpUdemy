using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // área da circunferência
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Area é: " + area);

            // ============ Tipos internos ===============            

            // true e false
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            // de 0 a 256
            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            // de -128 a 127
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            // de -32768 a 32767
            short salario = short.MaxValue;
            Console.WriteLine("Salário é: " + salario);

            // de -2147483648 a 2147483647
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor Valor de Int: " + menorValorInt);

            // de 0 a 4294967295
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira é: " + populacaoBrasileira);

            //  de -9223372036854775808 a 9223372036854775807
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor do Long é: " + menorValorLong);

            // de 0 a 18446744073709551615
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial é: " + populacaoMundial);

            // coloca-se o F ao final, pois sem ele o valor se torna um literal, um double
            float precoComputador = 1299.99F;
            Console.WriteLine("Preço do computador é: " + precoComputador);

            // -1.7976931348623157E+308 a 1.7976931348623157E+308
            double medidaTerreno = 455.56;
            Console.WriteLine("Medida do terreno é: " + medidaTerreno + "m2");

            // -79228162514264337593543950335 a 79228162514264337593543950335
            decimal distanciaEntreAsEstrelas = decimal.MinValue;
            Console.WriteLine("Distência entre as estrelas é: " + distanciaEntreAsEstrelas);

            // armazena um caractere apenas
            char letra = 'b';
            Console.WriteLine("Letra é: " + letra);

            // armazena um texto, ou seja, uma cadeia de caracteres
            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine("Texto é: " + texto);

        }
    }
}
