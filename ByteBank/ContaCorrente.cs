// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        public static int ContadorSaquesNaoPermitidos { get; private set; }
        public static int TransferenciasNaoPermitidas { get; private set; }

        public int Numero { get; } // cria o campo privado somente leitura de Numero
        public int Agencia { get; } // somente leitura


        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {                                                                           //PARAMNAME
                throw new ArgumentException("O argumento agencia deve ser maior que 0.",nameof(agencia)); //nameof transforma uma classe em string , nuca numeros em string 
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.",nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;


            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;

        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("valor inválido para que o saque ", nameof(valor)); // trasfoma a classe valor em uma string 
            }
           
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;// contador 
                throw new SaldoInsuficienteException(Saldo,valor); //Saldo da conta , valor do saque 
            }

            _saldo -= valor;
           
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("valor inválido para transferencia ", nameof(valor)); // trasfoma a classe valor em uma string 
            }
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException )
            {
                TransferenciasNaoPermitidas++;
                throw; //é preenchido a propriedade stacktrace, permitindo a rastreio da pilha com ex so ira aparecer o metodo transferir omitindo o metodo sacar 
                       // throw ex -- dessa forma so preenche o erro correto sem fazer a trilha do stack trace, perdendo a informação da pilha de chamadas
                       // somente com o Catch podemos passar a execeção sem o objeto sendo assim o retorno sera SaldoInsuficienteException )
                
            }
            
            contaDestino.Depositar(valor);
            
        }
    }
}
