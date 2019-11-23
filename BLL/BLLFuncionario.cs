using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFuncionario
    {
        public static void Incluir(MFuncionario modelo, MEndereco endereco)
        {
            //Para ficar tudo maiúsculo
            modelo.NomeFuncionario = modelo.NomeFuncionario.ToUpper();
            endereco.LogradouroEndereco = endereco.LogradouroEndereco.ToUpper();
            endereco.BairroEndereco = endereco.BairroEndereco.ToUpper();
            //Chamando o metodo Incluir
            DALFuncionario.Incluir(modelo, endereco);
        }

        public static void Alterar(MFuncionario modelo, MEndereco endereco)
        {
            //Para ficar tudo maiúsculo
            modelo.NomeFuncionario = modelo.NomeFuncionario.ToUpper();
            endereco.LogradouroEndereco = endereco.LogradouroEndereco.ToUpper();
            endereco.BairroEndereco = endereco.BairroEndereco.ToUpper();

            //Chamndo método Alterar
            DALFuncionario.Alterar(modelo, endereco);

        }
        public static DataTable LocalizarDados(String valor)
        {
            //Analisando se foi localizado algum registro
            if (DALFuncionario.LocalizarDados(valor).Rows.Count > 0)
            {
                return DALFuncionario.LocalizarDados(valor);
            }
            else
            {
                throw new Exception("Não foi encontrado nenhum registro!");
            }
        }
        public static void Excluir(int codigo)
        {
            DALFuncionario.Excluir(codigo);
        }
    }
}
