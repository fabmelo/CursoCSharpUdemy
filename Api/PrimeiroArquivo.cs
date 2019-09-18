using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {

            var dir = @"~/aulas-udemy".ParseHome();

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                EscreverArquivo();
            }
            else
            {
                EscreverArquivo();
            }

        }

        public static void EscreverArquivo()
        {
            var path = @"~/aulas-udemy/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}