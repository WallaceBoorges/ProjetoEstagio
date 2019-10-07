using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MCompra
    {
        public int CompraCod { get; set; }
        public DateTime CompraData { get; set; }
        public string CompraNotaFiscal { get; set; }
        public double CompraValor { get; set; }
        public int CompraParcelas { get; set; }
        public string CompraStatus { get; set; }
        public int FornecedorCod { get; set; }
        public int TipoPagCod { get; set; }
        public List<MItensCompra> Itens { get; set; } = new List<MItensCompra>();
        public List<MParcelasCompra> Parcelas { get; set; } = new List<MParcelasCompra>();

        public MCompra()
        {
            Itens = new List<MItensCompra>();
            Parcelas = new List<MParcelasCompra>();
        }

        public MCompra(DateTime compraData, string compraNotaFiscal, double compraValor, int compraParcelas, string compraStatus, int fornecedorCod, int tipoPagCod)
        {
            CompraData = compraData;
            CompraNotaFiscal = compraNotaFiscal;
            CompraValor = compraValor;
            CompraParcelas = compraParcelas;
            CompraStatus = compraStatus;
            FornecedorCod = fornecedorCod;
            TipoPagCod = tipoPagCod;
            Itens = new List<MItensCompra>();
            Parcelas = new List<MParcelasCompra>();
        }

        public MCompra(int compraCod, DateTime compraData, string compraNotaFiscal, double compraValor, int compraParcelas, string compraStatus, int fornecedorCod, int tipoPagCod)
        {
            CompraCod = compraCod;
            CompraData = compraData;
            CompraNotaFiscal = compraNotaFiscal;
            CompraValor = compraValor;
            CompraParcelas = compraParcelas;
            CompraStatus = compraStatus;
            FornecedorCod = fornecedorCod;
            TipoPagCod = tipoPagCod;
        }
    }
}
