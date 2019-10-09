using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCompra
    {
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Incluir(MCompra modelo)
        {
            DALCompra.Incluir(modelo);
        }
        public static void Alterar(MCompra modelo)
        {
            DALCompra.Alterar(modelo);
        }
        public static void Excluir(int codigo)
        {
            DALCompra.Excluir(codigo);
        }

    }
}
