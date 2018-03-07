using System.IO;
using System;
using System.IO.Compression;

namespace Benner.Saude.Postal.Zip.Business
{
    public class CompactaArquivo
    {
        public static void Compactar(string caminhoDoZip, string arquivo)
        {
            string[] arquivos = arquivo.Split('|');
            if (arquivo.Length > 0)
            {
                foreach (string item in arquivos)
                {
                    CompactarArquivo(caminhoDoZip, item);
                }
            }
            else
            {
                CompactarArquivo(caminhoDoZip, arquivo);
            }
        }

        private static void CompactarArquivo(string caminhoDoZip, string arquivo)
        {
            if (!File.Exists(arquivo))
                throw new Exception(string.Concat("Arquivo [", arquivo, "] não localizado."));

            if (!File.Exists(caminhoDoZip))
            {
                using (ZipArchive zip = ZipFile.Open(caminhoDoZip, ZipArchiveMode.Create))
                {
                    zip.CreateEntryFromFile(arquivo, Path.GetFileName(arquivo));
                }
            }
            else
            {
                using (ZipArchive zip = ZipFile.Open(caminhoDoZip, ZipArchiveMode.Update))
                {
                    zip.CreateEntryFromFile(arquivo, Path.GetFileName(arquivo));
                }
            }           
        }
    }
}
