namespace Modelo
{
    public class MProduto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public double ValorVendaProduto { get; set; }
        public double QuantProduto { get; set; }
        public string StatusProduto { get; set; }
        public int CodigoUnidadeMedida { get; set; }
        public int CodigoCategoria { get; set; }
        public int CodigoSubcategoria { get; set; }

        //Metodo construtor sem argurmento
        public MProduto()
        {

        }

        public MProduto(string nomeProduto, string descricaoProduto, double valorVendaProduto, double quantProduto, string statusProduto, int codigoUnidadeMedida, int codigoCategoria)
        {
            NomeProduto = nomeProduto;
            DescricaoProduto = descricaoProduto;
            ValorVendaProduto = valorVendaProduto;
            QuantProduto = quantProduto;
            StatusProduto = statusProduto;
            CodigoUnidadeMedida = codigoUnidadeMedida;
            CodigoCategoria = codigoCategoria;
        }

        public MProduto(int codigoProduto, string nomeProduto, string descricaoProduto, double valorVendaProduto, double quantProduto, string statusProduto, int codigoUnidadeMedida, int codigoCategoria, int codigoSubcategoria)
        {
            CodigoProduto = codigoProduto;
            NomeProduto = nomeProduto;
            DescricaoProduto = descricaoProduto;
            ValorVendaProduto = valorVendaProduto;
            QuantProduto = quantProduto;
            StatusProduto = statusProduto;
            CodigoUnidadeMedida = codigoUnidadeMedida;
            CodigoCategoria = codigoCategoria;
            CodigoSubcategoria = codigoSubcategoria;
        }

        public MProduto(int codigoProduto, string nomeProduto, string descricaoProduto, double valorVendaProduto, double quantProduto, string statusProduto, int codigoUnidadeMedida, int codigoCategoria)
        {
            CodigoProduto = codigoProduto;
            NomeProduto = nomeProduto;
            DescricaoProduto = descricaoProduto;
            ValorVendaProduto = valorVendaProduto;
            QuantProduto = quantProduto;
            StatusProduto = statusProduto;
            CodigoUnidadeMedida = codigoUnidadeMedida;
            CodigoCategoria = codigoCategoria;
        }

        public MProduto(string nomeProduto, string descricaoProduto, double valorVendaProduto, double quantProduto, string statusProduto, int codigoUnidadeMedida, int codigoCategoria, int codigoSubcategoria) : this(nomeProduto, descricaoProduto, valorVendaProduto, quantProduto, statusProduto, codigoUnidadeMedida, codigoCategoria)
        {
            CodigoSubcategoria = codigoSubcategoria;
        }
    }
}
