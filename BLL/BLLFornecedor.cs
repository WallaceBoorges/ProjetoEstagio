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
    public class BLLFornecedor
    {
        public static void Incluir(MFornecedor modelo, MEndereco endereco)
        {
            //Para ficar tudo maiúsculo
            modelo.NomeFornecedor = modelo.NomeFornecedor.ToUpper();
            modelo.EmailFornecedor = modelo.EmailFornecedor.ToUpper();
            endereco.LogradouroEndereco = endereco.LogradouroEndereco.ToUpper();
            endereco.BairroEndereco = endereco.BairroEndereco.ToUpper();
            //Chamando o metodo Incluir
            DALFornecedor.Incluir(modelo, endereco);
        }

        public static void Alterar(MFornecedor modelo, MEndereco endereco)
        {
            //Para ficar tudo maiúsculo
            modelo.NomeFornecedor = modelo.NomeFornecedor.ToUpper();
            modelo.EmailFornecedor = modelo.EmailFornecedor.ToUpper();
            endereco.LogradouroEndereco = endereco.LogradouroEndereco.ToUpper();
            endereco.BairroEndereco = endereco.BairroEndereco.ToUpper();

            //Chamndo método Alterar
            DALFornecedor.Alterar(modelo, endereco);

        }
        public static DataTable LocalizarDados(String valor)
        {
            //Analisando se foi localizado algum registro
            if (DALFornecedor.LocalizarDados(valor).Rows.Count > 0)
            {
                return DALFornecedor.LocalizarDados(valor);
            }
            else
            {
                throw new Exception("Não foi encontrado nenhum registro!");
            }
        }
        public static void Excluir(int codigo)
        {
            DALFornecedor.Excluir(codigo);
        }
    }
}
