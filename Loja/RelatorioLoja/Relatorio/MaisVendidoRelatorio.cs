using Newtonsoft.Json;
using RelatorioLoja.Extensao;
using RelatorioLoja.Interface;
using RelatorioLoja.Manipular;
using RelatorioLoja.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioLoja.Relatorio
{
    /// <summary>
    /// Responsavel pela operação referente ao relatório do produto mais vendido.
    /// </summary>
    public class MaisVendidoRelatorio : IRelatorio
    {
        /// <summary>
        ///  Faz a chamada do método GetMaisVendido.
        /// </summary>
        public ServicoVendas MaisVendidoServico { get; set; }
        /// <summary>
        /// Construtor padrão da classe que instância o atributo.
        /// </summary>
        public MaisVendidoRelatorio() => MaisVendidoServico = new ServicoVendas();
        /// <summary>
        /// Serializa o produto de maior venda.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Retorna a string serializada.</returns>
        public string Serializar(List<ProdutoModelo> produtos)
        {
            string estoque = JsonConvert.SerializeObject(MaisVendidoServico.GetMaisVendido(produtos));
            return estoque;
        }
        /// <summary>
        /// Gera o arquivo serializado.
        /// </summary>
        /// <param name="json">String serializada.</param>
        public void GerarArquivo(string json)
        {
            ManipuladorJSON manipularJSON = new ManipuladorJSON();
            manipularJSON.CriarArquivo(json, "MaisVendido");
        }
    }
}
