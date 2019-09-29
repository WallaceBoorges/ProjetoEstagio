using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MCliente
    {
        public int CodigoCliente { get; set; }
        public String NomeCliente { get; set; }
        public String TipoCliente { get; set; }
        public String RgCliente { get; set; }
        public String CpfCliente { get; set; }
        public String RsocialCliente { get; set; }
        public int FoneCliente { get; set; }
        public int CelCliente { get; set; }
        public String EmailCliente { get; set; }
        public int CodigoEndereco { get; set; }

        public MCliente()
        {
            this.CodigoCliente = 0;
            this.NomeCliente = "";
            this.TipoCliente = "";
            this.RgCliente = "";
            this.CpfCliente = "";
            this.RsocialCliente = "";
            this.FoneCliente = 0;
            this.CelCliente = 0;
            this.EmailCliente = "";
            this.CodigoCliente = 0;

        }

        public MCliente(string nomeCliente, string tipoCliente, string rgCliente, string cpfCliente, string rsocialCliente, int foneCliente, int celCliente, string emailCliente)
        {
            NomeCliente = nomeCliente;
            TipoCliente = tipoCliente;
            RgCliente = rgCliente;
            CpfCliente = cpfCliente;
            RsocialCliente = rsocialCliente;
            FoneCliente = foneCliente;
            CelCliente = celCliente;
            EmailCliente = emailCliente;
        }
    }
}
