using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DALParcelasCompra
    {
        /* Método para carregar os dados da tabela no DataGridView*/
        public static DataTable CarregarGrid()
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "Select* from categoria order by categoria_cod desc";
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }

        public static void Incluir(MParcelasCompra modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {

                        comm.CommandText = "INSERT INTO parcelascompra (parcelasCompra_valor, parcelasCompra_vecto, compra_cod) " +
                            "VALUES (@valor, @venc, @cod)";

                        //Passando o valores por parametro
                        comm.Parameters.Add(new SqlParameter("@valor", modelo.ParcelaCompraValor));
                        comm.Parameters.Add(new SqlParameter("@venc", modelo.ParcelaCompraVencimento));
                        comm.Parameters.Add(new SqlParameter("@cod", modelo.CompraCodigo));

                        //Executando o comando
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
