using Newtonsoft.Json;
using RelatorioLoja.Interface;
using RelatorioLoja.Manipular;
using RelatorioLoja.Modelo;
using RelatorioLoja.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioLoja.Relatorio
{
    /// <summary>
    /// Responsavel pela operação referente ao relatório do produto de maior venda.
    /// </summary>
    public class MaiorVendaRelatorio : IRelatorio
    {
        /// <summary>
        /// Faz a chamada do método GetMaisRentavel.
        /// </summary>
        public ServicoVendas MaiorVendaServico { get; set; }
        /// <summary>
        /// Construtor padrão da classe que instância o atributo.
        /// </summary>
        public MaiorVendaRelatorio() => MaiorVendaServico = new ServicoVendas();
        
        /// <summary>
        /// Serializa o produto de maior venda.
        /// </summary>
        /// <param name="produtos">produtos que serão verificados.</param>
        /// <returns>Retorna a string serializada.</returns>
        public string Serializar(List<ProdutoModelo> produtos)
        {
            string estoque = JsonConvert.SerializeObject(MaiorVendaServico.GetMaisRentavel(produtos));
            return estoque;
        }
        /// <summary>
        /// Gera o arquivo serializado.
        /// </summary>
        /// <param name="json">String serializada.</param>
        public void GerarArquivo(string json)
        {
            ManipuladorJSON manipularJSON = new ManipuladorJSON();
            manipularJSON.CriarArquivo(json, "MaiorVenda");
        }
    }
}
 