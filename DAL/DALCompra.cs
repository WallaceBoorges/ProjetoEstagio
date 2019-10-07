using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DAL
{
    public class DALCompra
    {
        public static List<MItensCompra> CarregaListaProdutos(int compra)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao())//Passando string de conexão
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())//Criando comando SQL
                    {
                        comm.CommandText = "select prod.*, iten.* from produto as prod " +
                        "inner join itenscompra as iten on prod.produto_cod = iten.produto_cod " +
                        "inner join compra as com on com.compra_cod = iten.compra_cod " +
                        "where iten.compra_cod = @idCompra";
                        comm.Parameters.Add(new SqlParameter("@idCompra", compra));//passando os valores por paremetro

                        var reader = comm.ExecuteReader();//Passando Comando
                        var table = new DataTable(); //Passando a tabela

                        List<MItensCompra> produtos = new List<MItensCompra>();

                        //foreach (DataRow dataRow in table.Rows)
                        while (reader.Read())
                        {
                            string ProdNome = reader["produto_nome"].ToString();
                            int ProdCodigo = int.Parse(reader["produto_cod"].ToString());
                            string ProdDesc = reader["produto_descricao"].ToString();
                            double ProdValorVenda = double.Parse(reader["produto_valorvenda"].ToString());
                            int ProdQtd = int.Parse(reader["produto_qtde"].ToString());
                            int ProdUnd = int.Parse(reader["uniMedida_cod"].ToString());
                            int ProdCategoria = int.Parse(reader["categoria_cod"].ToString());
                            string statusProduto = reader["produto_status"].ToString();
                            //item compra
                            int itemCompraCodigo = int.Parse(reader["itensCompra_cod"].ToString());
                            double itemCompraQuant = double.Parse(reader["itensCompra_qtde"].ToString());
                            double itemCompraValor = double.Parse(reader["itensCompra_valor"].ToString());
                            string itemCompraCodBarra = reader["itensCompra_CodigoBarra"].ToString();
                            DateTime itemCompraDataVencimento = Convert.ToDateTime(reader["itensCompra_vencimento"].ToString());


                            if (!(reader["subCategoria_cod"] is DBNull)) //caso não haja um subcategoria
                            {
                                int ProdSubCategoria = int.Parse(reader["subCategoria_cod"].ToString());

                                MProduto prod = new MProduto(ProdCodigo, ProdNome, ProdDesc, ProdValorVenda, ProdQtd, statusProduto, ProdUnd, ProdCategoria, ProdSubCategoria);
                                MItensCompra itens = new MItensCompra(itemCompraCodigo, itemCompraQuant, itemCompraValor, itemCompraCodBarra, itemCompraDataVencimento, prod);
                                produtos.Add(itens);

                            }
                            else
                            {
                                MProduto prod = new MProduto(ProdCodigo, ProdNome, ProdDesc, ProdValorVenda, ProdQtd, statusProduto, ProdUnd, ProdCategoria);
                                MItensCompra itens = new MItensCompra(itemCompraCodigo, itemCompraQuant, itemCompraValor, itemCompraCodBarra, itemCompraDataVencimento, prod);
                                produtos.Add(itens);
                            }


                        }

                        return produtos;
                    }

                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

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
        public static void Alterar(MCompra modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "update compra set compra_data = @data, compra_nfiscal = @nfiscal, " +
                            "compra_total = @total, compra_nparcelas = @nparcelas, compra_status = @status, " +
                            "fornecedor_cod = @forncod, tipoPag_cod = @tipopag where compra_cod = @compraCod";
                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@data", modelo.CompraData));
                        comm.Parameters.Add(new SqlParameter("@nfiscal", modelo.CompraNotaFiscal));
                        comm.Parameters.Add(new SqlParameter("@total", modelo.CompraValor));
                        comm.Parameters.Add(new SqlParameter("@nparcelas", modelo.CompraParcelas));
                        comm.Parameters.Add(new SqlParameter("@status", modelo.CompraStatus));
                        comm.Parameters.Add(new SqlParameter("@forncod", modelo.FornecedorCod));
                        comm.Parameters.Add(new SqlParameter("@tipopag", modelo.TipoPagCod));
                        comm.Parameters.Add(new SqlParameter("@compraCod", modelo.CompraCod));
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
