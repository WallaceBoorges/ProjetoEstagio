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
    public class BLLCliente
    {
        public static void Incluir(MCliente modelo, MEndereco endereco)
        {
            //Para ficar tudo maiúsculo
            modelo.NomeCliente = modelo.NomeCliente.ToUpper();
            modelo.EmailCliente = modelo.EmailCliente.ToUpper();
            endereco.LogradouroEndereco = endereco.LogradouroEndereco.ToUpper();
            endereco.BairroEndereco = endereco.BairroEndereco.ToUpper();
            //Chamando o metodo Incluir
            DALCliente.Incluir(modelo, endereco);
        }

        public static void Alterar(MCliente modelo, MEndereco endereco)
        {
            //Para ficar tudo maiúsculo
            modelo.NomeCliente = modelo.NomeCliente.ToUpper();
            modelo.EmailCliente = modelo.EmailCliente.ToUpper();
            endereco.LogradouroEndereco = endereco.LogradouroEndereco.ToUpper();
            endereco.BairroEndereco = endereco.BairroEndereco.ToUpper();

            //Chamndo método Alterar
            DALCliente.Alterar(modelo, endereco);

        }
        public static DataTable LocalizarDados(String valor)
        {
            //Analisando se foi localizado algum registro
            if (DALCliente.LocalizarDados(valor).Rows.Count > 0)
            {
                return DALCliente.LocalizarDados(valor);
            }
            else
            {
                throw new Exception("Não foi encontrado nenhum registro!");
            }
        }
        public static void Excluir(int codigo)
        {
            DALCliente.Excluir(codigo);
        }
    }
}
