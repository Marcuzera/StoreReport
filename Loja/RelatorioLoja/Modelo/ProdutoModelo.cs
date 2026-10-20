namespace RelatorioLoja
{
    /// <summary>
    /// Modelo para cada produto.
    /// </summary>
    public class ProdutoModelo
    {
        /// <summary>
        /// Id do produto.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Nome do produto.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Descrição do produto.
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Preço do produto.
        /// </summary>
        public double Preco { get; set; }
        /// <summary>
        /// Estoque do produto.
        /// </summary>
        public int Estoque { get; set; }
        /// <summary>
        /// QntVendas do produto.
        /// </summary>
        public int QntVendas { get; set; }
        /// <summary>
        /// Data de modificação do produto.
        /// </summary>
        public string DataModificacao { get; set; }
        /// <summary>
        /// Construtor padrão da classe.
        /// </summary>
        public ProdutoModelo() { }

        /// <summary>
        /// Inicializa os atributos da classe.
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <param name="nome">Nome do do produto</param>
        /// <param name="descricao">Descrição do produto</param>
        /// <param name="preco">Preco do produto</param>
        /// <param name="estoque">Quantida disponivel em estoque do produto</param>
        /// <param name="qntVendas">Quantidade de vendas do produto</param>
        /// <param name="dataModificacao">Data de modificação do produto</param>
        public ProdutoModelo(string id, string nome,
            string descricao, double preco, int estoque,
            int qntVendas, string dataModificacao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            QntVendas = qntVendas;
            DataModificacao = dataModificacao;
        }
    }
}
