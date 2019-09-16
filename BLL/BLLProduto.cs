using System;
using Modelo;
using DAL;

namespace BLL
{
    public class BLLProduto
    {
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Incluir(MProduto modelo)
        {            
            //Para ficar tudo maiúsculo
            modelo.NomeProduto = modelo.NomeProduto.ToUpper();
            modelo.DescricaoProduto = modelo.DescricaoProduto.ToUpper();
            //Chamando o metodo Incluir
            DALProduto.Incluir(modelo);
        }

        public static void Alterar(MProduto modelo)
        {
            //Para ficar tudo maiúsculo
            modelo.NomeProduto = modelo.NomeProduto.ToUpper();
            modelo.DescricaoProduto = modelo.DescricaoProduto.ToUpper();

            //Chamndo método Alterar
            DALProduto.Alterar(modelo);

        }
    }
}
