using Modelo;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLItensVenda
    {
        public static void Incluir(MItensVenda modelo)
        {
            //Chamando o metodo Incluir
            DALItensVenda.Incluir(modelo);
        }
    }
}