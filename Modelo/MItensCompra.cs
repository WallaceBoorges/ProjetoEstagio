using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MItensCompra
    {
        public int ItemCompraCodigo { get; set; }
        public double ItemCompraQuant { get; set; }
        public double ItemCompraValor { get; set; }
        public int CompraCodigo { get; set; }
        public int ProdutoCodigo { get; set; }

        public MItensCompra(double itemCompraQuant, double itemCompraValor, int compraCodigo)
        {
            ItemCompraQuant = itemCompraQuant;
            ItemCompraValor = itemCompraValor;
            CompraCodigo = compraCodigo;
        }
    }
}
