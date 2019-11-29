using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MVenda
    {
        public int VendaCod { get; set; }
        public DateTime VendaData { get; set; }
        public string VendaNotaFiscal { get; set; }
        public double VendaTotal { get; set; }
        public int VendaParcelas { get; set; }
        public double VendaTaxaParcela { get; set; }
        public string VendaStatus { get; set; }
        public int ClienteCod { get; set; }
        public int TipoPagamentoCod { get; set; }
        public int FuncionarioCod { get; set; }
        public List<MItensVenda> Itens { get; set; }
        public List<MParcelasVenda> Parcelas { get; set; }

        public MVenda()
        {
            Itens = new List<MItensVenda>();
            Parcelas = new List<MParcelasVenda>();
        }
    }
}
