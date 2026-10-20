using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RelatorioLoja.Extensao;

namespace RelatorioLoja.Modelo
{
    /// <summary>
    /// Modelo para operação referente aos produtos esgotados.
    /// </summary>
    public class EsgotadoModelo : ProdutoModelo
    {
        /// <summary>
        /// Produto esgotado.
        /// </summary>
        public ProdutoModelo Produto { get; set; }
        /// <summary>
        /// Inicializa os atributos da classe.
        /// </summary>
        /// <param name="produto">Produto esgotado.</param>
        public EsgotadoModelo(ProdutoModelo produto)
        {
            Produto = produto;
        }
    }
}
