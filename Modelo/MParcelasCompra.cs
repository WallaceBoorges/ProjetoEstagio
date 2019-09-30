using System;

namespace Modelo
{
    public class MParcelasCompra
    {
        public int ParcelaCompraCodigo { get; set; }
        public double ParcelaCompraValor { get; private set; }
        public DateTime ParcelaCompraDataPagamento { get; set; }
        public DateTime ParcelaCompraVencimento { get; set; }
        public int CompraCodigo { get; set; }

        public MParcelasCompra()
        {
        }

        public MParcelasCompra(double parcelaCompraValor, DateTime parcelaCompraVencimento, int compraCodigo)
        {
            ParcelaCompraValor = parcelaCompraValor;
            ParcelaCompraVencimento = parcelaCompraVencimento;
            CompraCodigo = compraCodigo;
        }


        public double ValorParcela(double valorTotal, int quantParcela)
        {
            ParcelaCompraValor = valorTotal / quantParcela;
            return ParcelaCompraValor;
        }
    }
}