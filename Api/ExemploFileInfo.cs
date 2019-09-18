using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOrigem = @"~/aulas-udemy/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/aulas-udemy/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/aulas-udemy/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine("Name: " + origem.Name);
            Console.WriteLine("IsReadOnly: " + origem.IsReadOnly);
            Console.WriteLine("FullName: " + origem.FullName);
            Console.WriteLine("Extension: " + origem.Extension);
            Console.WriteLine("DirectoryName: " + origem.DirectoryName);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}