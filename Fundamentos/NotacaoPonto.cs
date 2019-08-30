using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World", "Mundo").ToUpper();
            Console.WriteLine(saudacao);

            string valorImportante = null;
            /*
             * se não color o operador Elvis ? irá causar um bug, 
             * pois não é possível pegar o length de uma variável com valor null
             */
            Console.WriteLine(valorImportante?.Length); 
        }
    }
}
