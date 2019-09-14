﻿using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLCategoria
    {
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Incluir(MCategoria modelo)
        {
            if (modelo.categoria_nome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            //Para ficar tudo maiúsculo
            modelo.categoria_nome = modelo.categoria_nome.ToUpper();
            DALCategoria.Incluir(modelo);
        }
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Alterar(MCategoria modelo)
        {
            if (modelo.categoria_cod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório!");
            }

            if (modelo.categoria_nome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }
            //Para ficar tudo maiúsculo
            modelo.categoria_nome = modelo.categoria_nome.ToUpper();
            DALCategoria.Alterar(modelo);
        }
        /*Nos métodos abaixo ainda faltam acrescentar as restrições de usuário. Dentro dos métodos só foram apenas abertas as conexões
         com o banco de dados.*/
        public static void Excluir(int codigo)
        {
            DALCategoria.Excluir(codigo);
        }
        public static DataTable LocalizarDados(String valor)
        {
            //Analisando se foi localizado algum registro
            if (DALSubCategoria.LocalizarDados(valor).Rows.Count > 0)
            {
                return DALCategoria.LocalizarDados(valor);
            }
            else
            {
                throw new Exception("Não foi encontrado nenhum registro!");
            }            
        }
        public static DataTable CarregarGrid()
        {
            return DALCategoria.CarregarGrid();
        }
    }
}
