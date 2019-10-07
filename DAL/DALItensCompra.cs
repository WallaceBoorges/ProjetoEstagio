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

                        comm.CommandText = "INSERT INTO itenscompra (itensCompra_qtde, itensCompra_valor, itensCompra_qtdeVenda, itensCompra_codigoBarra, itensCompra_vencimento, compra_cod, produto_cod) " +
                            "VALUES (@quant, @valor, @venda, @barra, @vence, @comcod, @prodcod)";

                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@quant", modelo.ItemCompraQuant));
                        comm.Parameters.Add(new SqlParameter("@valor", modelo.ItemCompraValor));
                        comm.Parameters.Add(new SqlParameter("@venda", modelo.ItemCompraQuantVenda));
                        comm.Parameters.Add(new SqlParameter("@barra", modelo.ItemCompraCodBarra));
                        comm.Parameters.Add(new SqlParameter("@vence", modelo.ItemCompraDataVencimento));
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
        public static void Alterar(MItensCompra modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando string de conexão
                {
                    conn.Open(); //Abrindo conexao
                    using (var comm = conn.CreateCommand()) //CRiando comando SQL
                    {

                        comm.CommandText = "update itenscompra set itensCompra_qtde = @qtde, itensCompra_valor = @itensCompraValor, " +
                            "itensCompra_codigoBarra = @codBarra, itensCompra_vencimento = @vencimento " +
                            " where itensCompra_cod = @itensCompra_cod";


                        //Passando valores 
                        comm.Parameters.Add(new SqlParameter("@qtde", modelo.ItemCompraQuant));
                        comm.Parameters.Add(new SqlParameter("@itensCompraValor", modelo.ItemCompraValor));
                        comm.Parameters.Add(new SqlParameter("@codBarra", modelo.ItemCompraCodBarra));
                        comm.Parameters.Add(new SqlParameter("@vencimento", modelo.ItemCompraDataVencimento));
                        comm.Parameters.Add(new SqlParameter("@itensCompra_cod", modelo.ItemCompraCodigo));
                        //Executando comando

                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        //Pagando Valores
        public static DataTable PegarDados(int codigoProduto)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "SELECT * FROM itenscompra WHERE produto_cod = @cod";

                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@cod", codigoProduto));
                        var reader = comm.ExecuteReader(); //Passando o comando 
                        var table = new DataTable(); //Passando a tabela
                        table.Load(reader); //Carregando a tabela 
                        return table; //Retornando a consulta ao Banco de Dados
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
