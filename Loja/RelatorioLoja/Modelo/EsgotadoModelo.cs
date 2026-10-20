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
