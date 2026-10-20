using Newtonsoft.Json;
using RelatorioLoja.Interface;
using RelatorioLoja.Manipular;
using RelatorioLoja.Servico;
using System.Collections.Generic;

namespace RelatorioLoja.Relatorio
{
    /// <summary>
    /// Responsavel pela operação referente ao relatório de produtos esgotados.
    /// </summary>
    public class EsgotadoRelatorio : IRelatorio
    {
        /// <summary>
        /// Faz a chamada do método ListEsgotados.
        /// </summary>
        public ServicoEstoque EsgotadoServico { get; set; }
        /// <summary>
        /// Construtor padrão da classe que instância o atributo.
        /// </summary>
        public EsgotadoRelatorio() => EsgotadoServico = new ServicoEstoque();
        /// <summary>
        /// Serializa os produtos esgotados.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Retorna a string serializada.</returns>
        public string Serializar(List<ProdutoModelo> produtos)
        {
            var estoque = JsonConvert.SerializeObject(EsgotadoServico.ListEsgotados(produtos));
            return estoque;
        }
        /// <summary>
        /// Gera o arquivo serializado.
        /// </summary>
        /// <param name="json">String serializada.</param>
        public void GerarArquivo(string json)
        {
            ManipuladorJSON manipularJSON = new ManipuladorJSON();
            manipularJSON.CriarArquivo(json, "Esgotado");
        }
    }
}
