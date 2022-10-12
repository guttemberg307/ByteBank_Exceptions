using System;
using System.Collections.Generic;
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
                ContaCorrente conta1 = new ContaCorrente(4584, 584765);
                ContaCorrente conta2 = new ContaCorrente(44578, 854547);

                conta1.Transferir(10000, conta2);
            }
            catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXECEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message); // lembrando que so colocamos em evidencia a InnerExecption somente para visualização
                Console.WriteLine(e.InnerException.StackTrace); // poque o cliente so ira ver Operação nao realizada
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
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
                Console.WriteLine("Execeção com numero = " + numero +"e divisor = " + divisor);
                throw; // throw vai laçar a execeção para a proxima, lançado os resultados dos valores reais de numero e divisor 
            }
         
           
        }
    }
}
