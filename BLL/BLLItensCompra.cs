using DAL;
using Modelo;

namespace BLL
{
    public class BLLItensCompra
    {
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Incluir(MItensCompra modelo)
        {
            //Chamando o metodo Incluir
            DALItensCompra.Incluir(modelo);
        }
    }
}
