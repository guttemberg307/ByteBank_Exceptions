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
                ContaCorrente conta = new ContaCorrente(456, 5640);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema : " + ex.ParamName);//ParamName retorna um parametro especifico
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex )
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

          //  Metodo();

            Console.WriteLine("Execução finalizada.tecle enter para sair.");
            Console.ReadLine();
         

            //try
            //{
            //    Metodo();
            //}
            //catch(DivideByZeroException e)// DivideByZeroException trata um especificamente uma exceção, porem ela sempre tem que vi acima da (Exception erro) 
            //{                                // caso coloque abaixo vai surgir um erro explicando que a (Exception erro) ja faz a tratativa do erro.
            //    Console.WriteLine("Não é possível divisão por zero.");
            //}
            //catch (Exception e) //Exception faz o tratamento de todas as exceções
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace); //--StackTrace faz o rastreio da pilha de metodos
            //    Console.WriteLine("Aconteceu um erro!");
            //}


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
