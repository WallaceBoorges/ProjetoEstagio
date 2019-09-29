using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MFornecedor
    {
        public int CodigoFornecedor { get; set; }
        public String NomeFornecedor { get; set; }
        public String RsocialFornecedor { get; set; }
        public int IeFornecedor { get; set; }
        public int CnpjFornecedor { get; set; }
        public int FoneFornecedor { get; set; }
        public int CelFornecedor { get; set; }
        public String EmailFornecedor { get; set; }
        public int CodigoEndereco { get; set; }

        public MFornecedor()
        {
            this.CodigoFornecedor = 0;
            this.NomeFornecedor = "";
            this.RsocialFornecedor = "";
            this.IeFornecedor = 0;
            this.CnpjFornecedor = 0;
            this.FoneFornecedor = 0;
            this.CelFornecedor = 0;
            this.EmailFornecedor = "";
            this.CodigoEndereco = 0;

        }

        public MFornecedor(string nomeFornecedor, string rsocialFornecedor, int ieFornecedor, int cnpjFornecedor, int foneFornecedor, int celFornecedor, string emailFornecedor)
        {
            NomeFornecedor = nomeFornecedor;
            RsocialFornecedor = rsocialFornecedor;
            IeFornecedor = ieFornecedor;
            CnpjFornecedor = cnpjFornecedor;
            FoneFornecedor = foneFornecedor;
            CelFornecedor = celFornecedor;
            EmailFornecedor = emailFornecedor;
        }
    }
}
