using DAL;
using Modelo;

namespace BLL
{
    public class BLLParcelasCompras
    {
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Incluir(MParcelasCompra modelo)
        {
            DALParcelasCompra.Incluir(modelo);
        }
    }
}
