namespace Modelo
{
    public class MProduto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public double ValorPagoProduto { get; set; }
        public double ValorVendaProduto { get; set; }
        public double QuantProduto { get; set; }
        public int CodigoUnidadeMedida { get; set; }
        public int CodigoCategoria { get; set; }
        public int CodigoSubcategoria { get; set; }

        //Metodo construtor sem argurmento
        public MProduto()
        {

        }
        //Metodo construtor sem a subcategoria
        public MProduto(int codigoProduto, string nomeProduto, string descricaoProduto, double valorPagoProduto, double valorVendaProduto, double quantProduto, int codigoUnidadeMedida, int codigoCategoria)
        {
            CodigoProduto = codigoProduto;
            NomeProduto = nomeProduto;
            DescricaoProduto = descricaoProduto;
            ValorPagoProduto = valorPagoProduto;
            ValorVendaProduto = valorVendaProduto;
            QuantProduto = quantProduto;
            CodigoUnidadeMedida = codigoUnidadeMedida;
            CodigoCategoria = codigoCategoria;
        }
        //Metodo sem o id e o subcategoria
        public MProduto(string nomeProduto, string descricaoProduto, double valorPagoProduto, double valorVendaProduto, double quantProduto, int codigoUnidadeMedida, int codigoCategoria)
        {
            NomeProduto = nomeProduto;
            DescricaoProduto = descricaoProduto;
            ValorPagoProduto = valorPagoProduto;
            ValorVendaProduto = valorVendaProduto;
            QuantProduto = quantProduto;
            CodigoUnidadeMedida = codigoUnidadeMedida;
            CodigoCategoria = codigoCategoria;
        }
        //metodo construtor com todos os argumentos
        public MProduto(int codigoProduto, string nomeProduto, string descricaoProduto, double valorPagoProduto, double valorVendaProduto, double quantProduto, int codigoUnidadeMedida, int codigoCategoria, int codigoSubcategoria)
        {
            CodigoProduto = codigoProduto;
            NomeProduto = nomeProduto;
            DescricaoProduto = descricaoProduto;
            ValorPagoProduto = valorPagoProduto;
            ValorVendaProduto = valorVendaProduto;
            QuantProduto = quantProduto;
            CodigoUnidadeMedida = codigoUnidadeMedida;
            CodigoCategoria = codigoCategoria;
            CodigoSubcategoria = codigoSubcategoria;
        }
    }
}
