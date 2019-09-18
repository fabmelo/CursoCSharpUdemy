using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/Downloads".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos ================");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n== Diretórios ================");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\nCreationTime: " + dirInfo.CreationTime);
            Console.WriteLine("FullName: " + dirInfo.FullName);
            Console.WriteLine("Root: " + dirInfo.Root);
            Console.WriteLine("Parent: " + dirInfo.Parent.Parent);
        }
    }
}