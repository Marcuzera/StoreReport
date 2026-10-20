using System;
using System.Globalization;
using System.Xml.Linq;
using RelatorioLoja.GerenciarEstoque;

namespace RelatorioLoja.Manipular
{
    /// <summary>
    /// Reponsavel pelas ações dos arquivos de extensão xml.
    /// </summary>
    public class ManipuladorXML
    {
        /// <summary>
        /// Analisa as informações do produto.
        /// </summary>
        /// <param name="arquivo">Endereço do arquivo</param>
        public void AnalisarArquivo(string arquivo)
        {
            var doc = XDocument.Load(arquivo);

            foreach (XElement node in doc.Descendants("Product"))
            {
                CultureInfo provider = CultureInfo.InvariantCulture;

                var Id = node?.Attribute("id")?.Value;

                var Nome = node?.Element("Name")?.Value;

                var Descricao = node?.Element("Details")?.Element("Description")?.Value.Trim();
                var Preco = Convert.ToDouble((node?.Element("Details")?.Element("Price")?.Value), provider);

                var QntEstoque = Int32.Parse((node?.Element("SalesInformation")?.Element("InStockQuantity")?.Value));
                var QntVendas = Int32.Parse((node?.Element("SalesInformation")?.Element("SoldQuantity")?.Value));

                var DataModificacao = node?.Element("ModificationDate")?.Value;

                Estoque.AtribuirValores(Id, Nome, Descricao, Preco,
                    QntEstoque, QntVendas, DataModificacao);
            }
        }
    }
}
