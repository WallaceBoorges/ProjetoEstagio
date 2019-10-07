using System;

namespace Modelo
{
    public class MItensCompra
    {
        public int ItemCompraCodigo { get; set; }
        public double ItemCompraQuant { get; set; }
        public double ItemCompraQuantVenda { get; set; }
        public double ItemCompraValor { get; set; }
        public string ItemCompraCodBarra { get; set; }
        public DateTime ItemCompraDataVencimento { get; set; }
        public int CompraCodigo { get; set; }
        public MProduto Produto { get; set; }

        public MItensCompra()
        {
        }

        public MItensCompra(double itemCompraQuant, double itemCompraValor, string itemCompraCodBarra, DateTime itemCompraDataVencimento, MProduto produto)
        {
            ItemCompraQuantVenda = 0;
            CompraCodigo = 0;
            ItemCompraQuant = itemCompraQuant;
            ItemCompraValor = itemCompraValor;
            ItemCompraCodBarra = itemCompraCodBarra;
            ItemCompraDataVencimento = itemCompraDataVencimento;
            Produto = produto;
        }


        public MItensCompra(int itemCompraCodigo, double itemCompraQuant, double itemCompraValor, string itemCompraCodBarra, DateTime itemCompraDataVencimento, MProduto produto)
        {
            ItemCompraCodigo = itemCompraCodigo;
            ItemCompraQuant = itemCompraQuant;
            ItemCompraValor = itemCompraValor;
            ItemCompraCodBarra = itemCompraCodBarra;
            ItemCompraDataVencimento = itemCompraDataVencimento;
            Produto = produto;
        }
    }
}