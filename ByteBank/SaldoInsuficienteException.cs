using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException // convenção de boa praticaas terminar com exception
    {
        public double Saldo { get; } // privado e somente leitura 
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }
        // THIS chama o contrutor dessa classe, onde podemos escrever a nossa menssagem com referencia ao valorSaque e a saldo
        public SaldoInsuficienteException(double saldo, double valorSaque) // recebe como argumento o saldo e tentativa de saque 
        : this("tentativa de saque com valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo; // Saldo argumento , saldo propriedade
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {

        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {
            // talvez nao seja utilizado esse construtor , mas é uma boa pratica cria-lo como uma boa pratica
            // essa classe é usada como um padrao quando criamos uma Exeception que nao seja do c sharp

        }

    }
}
