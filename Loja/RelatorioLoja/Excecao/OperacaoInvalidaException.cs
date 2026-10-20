using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioLoja.Excecao
{
    /// <summary>
    /// Exceção gerada em caso de operação invalida.
    /// </summary>
    public class OperacaoInvalidaException : Exception
    {       
        /// <summary>
        /// Construtor Padrão da Classe.
        /// </summary>
        public OperacaoInvalidaException(){}
        /// <summary>
        /// Inicializa o construtor da classe e recebe uma mensagem informando o erro.
        /// </summary>
        /// <param name="mensagem">Mensagem especificando o erro.</param>
        public OperacaoInvalidaException(string mensagem) : base(mensagem){}

    }
}
