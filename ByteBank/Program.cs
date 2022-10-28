using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception) // por nao ser uma boa pratica somente para aplicação não fechar
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas() //metodo de carregar contas 
        {

            using ( LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                //IDispo
                leitor.LerProximaLinha();
            }


            //LeitorDeArquivo leitor = null; // leitor recebe o resultado nulo 
            //try
            //{
            //    leitor = new LeitorDeArquivo("contasl.txt"); // inscia do leitor de arquivos com o arquivo contas.txt para leitura 

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //}// permos ter um try ou um catch mais vai ser obrigatorio ter um finally 
            //finally// Finally vai ser executanto sempre aconteça uma exceção ou não.
            //{
            //    if (leitor != null) // se for diferente de nulo fechara autmaticamente caso não seja nulo a exceção sera tratada pois não foi encontrato o arquivo
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4584, 584765);
                ContaCorrente conta2 = new ContaCorrente(44578, 854547);

                conta1.Transferir(10000, conta2);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXECEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message); // lembrando que so colocamos em evidencia a InnerExecption somente para visualização
                Console.WriteLine(e.InnerException.StackTrace); // poque o cliente so ira ver Operação nao realizada
            }
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            // TestaDivisao(2);
            TestaDivisao(0);
        }

        public static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Execeção com numero = " + numero + "e divisor = " + divisor);
                throw; // throw vai laçar a execeção para a proxima, lançado os resultados dos valores reais de numero e divisor 
            }


        }
    }
}
