using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {

        int a = 10;
        public static void Executar()
        {
            DesafioAtributo valor = new DesafioAtributo();
            Console.WriteLine($"Valor da variável a é {valor.a}");
        }
    }
}
