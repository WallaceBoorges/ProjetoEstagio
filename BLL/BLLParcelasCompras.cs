using DAL;
using Modelo;

namespace BLL
{
    public class BLLParcelasCompras
    {
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Incluir(int quant, MParcelasCompra modelo)
        {
            DALParcelasCompra.Incluir(quant, modelo);
        }
    }
}
