using Newtonsoft.Json;
using RelatorioLoja.Interface;
using RelatorioLoja.Manipular;
using RelatorioLoja.Servico;
using System.Collections.Generic;

namespace RelatorioLoja.Relatorio
{
    /// <summary>
    /// Responsavel pela operação referente ao relatório de produtos não vendidos.
    /// </summary>
    public class NaoVendidoRelatorio : IRelatorio
    {
        /// <summary>
        /// Faz a chamada do método ListNaoVendidos.
        /// </summary>
        public ServicoVendas NaoVendidoServico { get; set; }
        /// <summary>
        /// Construtor padrão da classe que instância o atributo.
        /// </summary>
        public NaoVendidoRelatorio() => NaoVendidoServico = new ServicoVendas();
        /// <summary>
        /// Serializa os produtos não vendidos.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Retorna a string serializada.</returns>
        public string Serializar(List<ProdutoModelo> produtos)
        {
            string estoque = JsonConvert.SerializeObject(NaoVendidoServico.ListNaoVendidos(produtos));
            return estoque;
        }
        /// <summary>
        /// Gera o arquivo serializado.
        /// </summary>
        /// <param name="json">String serializada.</param>
        public void GerarArquivo(string json)
        {
            ManipuladorJSON manipularJSON = new ManipuladorJSON();
            manipularJSON.CriarArquivo(json, "NaoVendido");
        }
    }
}
