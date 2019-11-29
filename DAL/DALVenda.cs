using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVenda
    {
        /* Método para carregar os dados da tabela no DataGridView*/
        public static DataTable CarregarGrid()
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "SELECT * FROM venda";
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }

        public static void Incluir(MVenda modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        if (modelo.ClienteCod == 0)
                        {
                            comm.CommandText = "INSERT INTO venda (venda_data, venda_nfiscal, venda_total, venda_nparcelas, venda_taxaParcela, venda_status, tipoPag_cod, fun_cod) " +
                            "VALUES(@data, @nfiscal, @total, @nparcelas, @taxa, @status, @tipopag, @funcod)";
                        }
                        else
                        {
                            comm.CommandText = "INSERT INTO venda (venda_data, venda_nfiscal, venda_total, venda_nparcelas, venda_taxaParcela, venda_status, cliente_cod, tipoPag_cod, fun_cod) " +
                            "VALUES (@data, @nfiscal, @total, @nparcelas, @taxa, @status, @codcliente, @tipopag, @funcod)";

                            comm.Parameters.Add(new SqlParameter("@codcliente", modelo.ClienteCod));
                        }

                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@data", modelo.VendaData));
                        comm.Parameters.Add(new SqlParameter("@nfiscal", modelo.VendaNotaFiscal));
                        comm.Parameters.Add(new SqlParameter("@total", modelo.VendaTotal));
                        comm.Parameters.Add(new SqlParameter("@nparcelas", modelo.VendaParcelas));
                        comm.Parameters.Add(new SqlParameter("@taxa", modelo.VendaTaxaParcela));
                        comm.Parameters.Add(new SqlParameter("@status", modelo.VendaStatus));
                        comm.Parameters.Add(new SqlParameter("@funcod", modelo.FuncionarioCod));
                        comm.Parameters.Add(new SqlParameter("@tipopag", modelo.TipoPagamentoCod));
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
                        comm.CommandText = "Select TOP 1 venda_cod from venda order by venda_cod desc";
                        var reader = comm.ExecuteReader(); //Passando o comando 
                        var table = new DataTable(); //Passando a tabela
                        table.Load(reader); //Carregando a tabela
                        return table.Rows[table.Rows.Count - 1]["venda_cod"].ToString(); //Pegando o id da avaliação
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
