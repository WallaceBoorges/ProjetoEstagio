using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCompra
    {
        /* Método para carregar os dados da tabela no DataGridView*/
        public static DataTable CarregarGrid()
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "SELECT co.compra_cod, co.compra_data, co.compra_nfiscal, co.compra_total, co.compra_nparcelas, co.compra_status, tipo.*, fo.* " +
                        "FROM compra as co " +
                        "inner join tipopagamento as tipo on co.tipoPag_cod = tipo.tipoPag_cod " +
                        "inner join fornecedor as fo on co.fornecedor_cod = fo.fornecedor_cod";
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }
        //Excluindo a compra
        public static void Excluir(int codigo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "DELETE FROM compra WHERE compra_cod = @id";
                        //Passando o valores por parametro
                        comm.Parameters.Add(new SqlParameter("@id", codigo));
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

        public static void Incluir(MCompra modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "INSERT INTO compra (compra_data, compra_nfiscal, compra_total, compra_nparcelas, compra_status, fornecedor_cod, tipoPag_cod) " +
                             "VALUES (@data, @nfiscal, @total, @nparcelas, @status, @forncod, @tipopag)"; 
                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@data", modelo.CompraData));
                        comm.Parameters.Add(new SqlParameter("@nfiscal", modelo.CompraNotaFiscal));
                        comm.Parameters.Add(new SqlParameter("@total", modelo.CompraValor));
                        comm.Parameters.Add(new SqlParameter("@nparcelas", modelo.CompraParcelas));
                        comm.Parameters.Add(new SqlParameter("@status", modelo.CompraStatus));
                        comm.Parameters.Add(new SqlParameter("@forncod", modelo.FornecedorCod));
                        comm.Parameters.Add(new SqlParameter("@tipopag", modelo.TipoPagCod));
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

        public static string PegarId()
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "Select TOP 1 compra_cod from compra order by compra_cod desc";
                        var reader = comm.ExecuteReader(); //Passando o comando 
                        var table = new DataTable(); //Passando a tabela
                        table.Load(reader); //Carregando a tabela
                        return table.Rows[table.Rows.Count - 1]["compra_cod"].ToString(); //Pegando o id da avaliação
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
