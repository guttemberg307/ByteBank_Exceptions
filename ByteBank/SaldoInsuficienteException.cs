using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public  class SaldoInsuficienteException : Exception // convenção de boa praticaas terminar com exception
    {

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
