using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public MParcelasCompra(double parcelaCompraValor, DateTime parcelaCompraDataPagamento, DateTime parcelaCompraVencimento)
        {
            ParcelaCompraValor = parcelaCompraValor;
            ParcelaCompraDataPagamento = parcelaCompraDataPagamento;
            ParcelaCompraVencimento = parcelaCompraVencimento;
        }

        public MParcelasCompra(double parcelaCompraValor, DateTime parcelaCompraDataPagamento, DateTime parcelaCompraVencimento, int compraCodigo) : this(parcelaCompraValor, parcelaCompraDataPagamento, parcelaCompraVencimento)
        {
            CompraCodigo = compraCodigo;
        }

        public double ValorParcela(double valorTotal, int quantParcela)
        {
            ParcelaCompraValor = valorTotal / quantParcela;
            return ParcelaCompraValor;
        }
    }
}
