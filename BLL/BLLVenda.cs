using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVenda
    {
        public static void Incluir(MVenda modelo)
        {
            DALVenda.Incluir(modelo);
        }
    }
}
