using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLParcelasVenda
    {
        public static void Incluir(MParcelasVenda modelo)
        {
            DALParcelasVenda.Incluir(modelo);
        }
    }
}
