using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALParcelasVenda
    {
        public static void Incluir(MParcelasVenda modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {

                        comm.CommandText = "INSERT INTO parcelasvenda (parcelasVenda_valor, parcelasVenda_tadavecto, venda_cod) " +
                            "VALUES (@valor, @venc, @cod)";

                        //Passando o valores por parametro
                        comm.Parameters.Add(new SqlParameter("@valor", modelo.ParcelaVendaValor));
                        comm.Parameters.Add(new SqlParameter("@venc", modelo.ParcelaVendaVencimento));
                        comm.Parameters.Add(new SqlParameter("@cod", modelo.VendaCodigo));

                        //Executando o comando
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {
                //Apagando a compra caso ocorra algum erro
                DALCompra.Excluir(int.Parse(DALCompra.PegarId()));
                throw new Exception(erro.Message);
            }
        }
    }
}
