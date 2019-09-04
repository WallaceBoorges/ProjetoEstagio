using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MUnidadeMedida
    {
        public int codigoUniMedida { get; set; }
        public String nomeUniMedida { get; set; }

        
        public MUnidadeMedida()
        {
            this.codigoUniMedida = 0;
            this.nomeUniMedida = "";
        }
        
        public MUnidadeMedida(int codigo, String nome)
        {
            this.codigoUniMedida = codigo;
            this.nomeUniMedida = nome;
        }
        public MUnidadeMedida(string NomeUniMedida)
        {
            nomeUniMedida = NomeUniMedida;
        }

    }
}
