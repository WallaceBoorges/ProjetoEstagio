using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MItensVenda
    {
        public int ItensVendaCod { get; set; }
        public double ItensVendaQuant { get; set; }
        public double ItensVendaValor { get; set; }
        public int VendaCod { get; set; }
        public MProduto Produto { get; set; }

        public MItensVenda(double itensVendaQuant, MProduto produto)
        {
            ItensVendaQuant = itensVendaQuant;
            Produto = produto;
        }

        public void Valor()
        {
            ItensVendaValor = ItensVendaQuant * Produto.ValorVendaProduto;
        }
    }
}
