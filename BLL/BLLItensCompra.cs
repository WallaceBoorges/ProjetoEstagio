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


        public static void Alterar(MItensCompra modelo)
        {
            //chamando método Alterar
            DALItensCompra.Alterar(modelo);
        }

        public static void Excluir(int codigo)
        {
            DALItensCompra.Excluir(codigo);
        }
    }
}
