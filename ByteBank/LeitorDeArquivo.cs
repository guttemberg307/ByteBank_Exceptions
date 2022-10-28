using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
         


          //  throw new FileNotFoundException(); //execeção definida no.NET quando não é encontrado um arquivo

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

           throw new IOException();// execeção definida no .NET onde tem imput e output/ entrada e saida 

            return "Linha do arquivo";
        }

        public void Dispose()
         {
            // metodo que tem a responsabiliadde de liberar os recursos 
            //
            Console.WriteLine("Fechando arquivo.");
           
        }
    }
}
