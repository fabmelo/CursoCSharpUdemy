using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // inverte o sinal
            Console.WriteLine(!booleano); // altera o valor booleano

            numero1++; // PÓS-FIXADO incrementa 1 ao valor
            Console.WriteLine(numero1);

            --numero1; // PRÉ-FIXADO decrementa 1 do valor
            Console.WriteLine(numero1);

            // neste caso 
            // o numero1 (pós-fixado) será incrementado após a comparação
            // e o numero 2 (pré-fixado) será decrementado antes da comparação
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}