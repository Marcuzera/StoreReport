using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelatorioLoja.Modelo;

namespace RelatorioLoja.Interface
{
    /// <summary>
    /// Interface para os relatórios.
    /// </summary>
    public interface IRelatorio
    {
        /// <summary>
        /// Serialização dos produtos.
        /// </summary>
        /// <param name="produto">Produtos que serão serializados.</param>
        /// <returns>Retorna a string serializada.</returns>
        string Serializar(List<ProdutoModelo> produtos);
        /// <summary>
        /// Gera o arquivo serializado.
        /// </summary>
        /// <param name="json">String serializada.</param>
        void GerarArquivo(string json);
    }
}
