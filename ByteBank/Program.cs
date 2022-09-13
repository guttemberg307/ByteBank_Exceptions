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
            catch (NullReferenceException erro)
            {
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
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException erro)//DivideByZeroException é um objeto
            {
                Console.WriteLine(erro.Message); // Menssage traz a menssagem do objeto de referencia (DivideByZeroException)
                Console.WriteLine(erro.StackTrace); //
                Console.WriteLine("Não é possível fazer uma divisão por 0!");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
           // Console.WriteLine(conta.Saldo);
         
            return numero / divisor;
        }
    }
}
