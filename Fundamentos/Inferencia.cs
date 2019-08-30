using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            /*
             * não foi definido o tipo, porém através da inferência de tipos o C# identificou 
             * por meio do dado informado que a variável é do tipo string
             */
            var nome = "Fabiano";
            Console.WriteLine(nome.GetType());
        }
    }
}
