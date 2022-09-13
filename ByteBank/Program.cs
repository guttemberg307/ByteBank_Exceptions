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
                Metodo();
            }
            catch(DivideByZeroException erro)// DivideByZeroException trata um especificamente uma exceção, porem ela sempre tem que vi acima da (Exception erro) 
            {                                // caso coloque abaixo vai surgir um erro explicando que a (Exception erro) ja faz a tratativa do erro.
                Console.WriteLine("Não é possível divisão por zero.");
            }
            catch (Exception erro) //Exception faz o tratamento de todas as exceções
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace); //--StackTrace faz o rastreio da pilha de metodos
                Console.WriteLine("Aconteceu um erro!");
            }

            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            //TestaDivisao(2);
            TestaDivisao(0);
        }

        public static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
           
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
           // Console.WriteLine(conta.Saldo);
         
            return numero / divisor;
        }
    }
}
