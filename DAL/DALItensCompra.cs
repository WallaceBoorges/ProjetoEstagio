using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALItensCompra
    {
        //Incluindo varios produtos
        public static void Incluir(MItensCompra modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {                        
                        //Pegando o id do ultimo produto cadastrado
                        comm.CommandText = "Select TOP 1 produto_cod from produto order by produto_cod desc";
                        var reader = comm.ExecuteReader(); //Passando o comando 
                        var table = new DataTable(); //Passando a tabela
                        table.Load(reader); //Carregando a tabela
                        string idProduto = table.Rows[table.Rows.Count - 1]["produto_cod"].ToString(); //Pegando o id da avaliação

                        comm.CommandText = "INSERT INTO itenscompra (itensCompra_qtde, itensCompra_valor, compra_cod, produto_cod) " +
                            "VALUES (@quant, @valor, @comcod, @prodcod)";

                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@quant", modelo.ItemCompraQuant));
                        comm.Parameters.Add(new SqlParameter("@valor", modelo.ItemCompraValor));
                        comm.Parameters.Add(new SqlParameter("@comcod", modelo.CompraCodigo));
                        comm.Parameters.Add(new SqlParameter("@prodcod", idProduto));
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
