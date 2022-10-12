using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class OperacaoFinanceiraException : Exception // toda nova classe exception deve herdar de EXCEPTION
    {
        public OperacaoFinanceiraException()// contrturores criatos em todos os objetos de exceções 
        {
            // contrutor sem argumentos 
        }
        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {
            //construtor com um argumento de menssagem, mandando para classe base, lembrando que a propriedade MENSSAGEM É PRIVADA PARA O TIPO EXCEPTION
        }
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base (mensagem, excecaoInterna)
        {
            // construtor que recebe a menssagem e a INNEREXCEPTION chamada de excecaoInterna
            // sabendo que a MENSSAGEM É PRIVADA  passando a mensagem do segundo contrutor "excecaoInterna" que é publica.
        }
    }
}
