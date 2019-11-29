using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MParcelasVenda
    {
        public int ParcelaVendaCodigo { get; set; }
        public double ParcelaVendaValor { get; private set; }
        public DateTime ParcelaVendaDataPagamento { get; set; }
        public DateTime ParcelaVendaVencimento { get; set; }
        public int VendaCodigo { get; set; }

        public MParcelasVenda(double parcelaVendaValor, DateTime parcelaVendaVencimento, int vendaCodigo)
        {
            ParcelaVendaValor = parcelaVendaValor;
            ParcelaVendaVencimento = parcelaVendaVencimento;
            VendaCodigo = vendaCodigo;
        }
    }
}