using System;
using Modelo;
using DAL;
using System.Data;
using System.Collections.Generic;

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

        public static void Alterar(int idProduto)
        {
            DALProduto.Alterar(idProduto);
        }

        /*Nos métodos abaixo ainda faltam acrescentar as restrições de usuário. Dentro dos métodos só foram apenas abertas as conexões
         com o banco de dados.*/
        public static void Excluir(int codigo)
        {
            DALProduto.Excluir(codigo);
        }
        public static DataTable LocalizarDados(String valor)
        {
            if (valor == "")
            {
                return DALProduto.CarregarGrid();
            }
            else
            {
                //Analisando se foi localizado algum registro
                if (DALProduto.LocalizarDados(valor).Rows.Count > 0)
                {
                    return DALProduto.LocalizarDados(valor);
                }
                else
                {
                    throw new Exception("Não foi encontrado nenhum registro!");
                }
            }
        }
    }
}
