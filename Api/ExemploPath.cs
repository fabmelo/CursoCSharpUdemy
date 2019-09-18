using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/aulas-udemy/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/aulas-udemy/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine("GetExtension: " + Path.GetExtension(arquivo));
            Console.WriteLine("GetFileName: " + Path.GetFileName(arquivo));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(arquivo));
            Console.WriteLine("HasExtension: " + Path.HasExtension(arquivo));

            Console.WriteLine("HasExtension: " + Path.HasExtension(pasta));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(pasta));
            Console.WriteLine("GetPathRoot: " + Path.GetPathRoot(pasta));
        }
    }
}