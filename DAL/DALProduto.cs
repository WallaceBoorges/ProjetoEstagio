using System;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace DAL
{
    public class DALProduto
    {
        /* Método para carregar os dados da tabela no DataGridView*/
        public static DataTable CarregarGrid()
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "SELECT prod.*, uni.uniMedida_nome, cat.categoria_nome, sub.subCategoria_nome FROM  produto as prod " +
                        "LEFT JOIN undmedida as uni on prod.uniMedida_cod = uni.uniMedida_cod " +
                        "LEFT JOIN categoria as cat on prod.categoria_cod = cat.categoria_cod " +
                        "LEFT JOIN subcategoria as sub on prod.subCategoria_cod = sub.subCategoria_cod";
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }
        public static void Alterar(MProduto modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando string de conexão
                {
                    conn.Open(); //Abrindo conexao
                    using (var comm = conn.CreateCommand()) //CRiando comando SQL
                    {
                        if (modelo.CodigoSubcategoria != 0)
                        {
                            comm.CommandText = "update produto set produto_nome = @nome, produto_descricao = @descricao, "
                                + " produto_valorpago = @valorpago, produto_valorvenda = @valorvenda, produto_qtde = @qtde, "
                                + "uniMedida_cod = @uniMedida_cod, categoria_cod = @categoria_cod, subCategoria_cod = @subCategoria_cod where produto_cod = @codigo";

                            comm.Parameters.Add(new SqlParameter("@subCategoria_cod", modelo.CodigoSubcategoria));
                        }
                        else
                        {
                            comm.CommandText = "update produto set produto_nome = @nome, produto_descricao = @descricao, "
                                + " produto_valorpago = @valorpago, produto_valorvenda = @valorvenda, produto_qtde = @qtde, "
                                + "uniMedida_cod = @uniMedida_cod, categoria_cod = @categoria_cod, subCategoria_cod = null where produto_cod = @codigo";
                        }

                        //Passando valores 
                        comm.Parameters.Add(new SqlParameter("@nome", modelo.NomeProduto));
                        comm.Parameters.Add(new SqlParameter("@descricao", modelo.DescricaoProduto));
                        comm.Parameters.Add(new SqlParameter("@valorpago", Math.Round(modelo.ValorPagoProduto, 2)));
                        comm.Parameters.Add(new SqlParameter("@valorvenda", Math.Round(modelo.ValorVendaProduto, 2)));
                        comm.Parameters.Add(new SqlParameter("@uniMedida_cod", modelo.CodigoUnidadeMedida));
                        comm.Parameters.Add(new SqlParameter("@categoria_cod", modelo.CodigoCategoria));
                        comm.Parameters.Add(new SqlParameter("@qtde", modelo.QuantProduto));
                        comm.Parameters.Add(new SqlParameter("@codigo", modelo.CodigoProduto));
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
        public static void Incluir(MProduto modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        //Analisando se vai ter uma subcategoria
                        if (modelo.CodigoSubcategoria != 0)
                        {
                            comm.CommandText = "INSERT INTO produto (produto_nome, produto_descricao, produto_valorpago, produto_valorvenda, produto_qtde, uniMedida_cod, categoria_cod, subCategoria_cod) " +
                            "VALUES (@nome, @desc, @pago, @venda, @quant, @unidade, @categoria, @subcategoria)";

                            comm.Parameters.Add(new SqlParameter("@subcategoria", modelo.CodigoSubcategoria));
                        }
                        else
                        {
                            comm.CommandText = "INSERT INTO produto (produto_nome, produto_descricao, produto_valorpago, produto_valorvenda, produto_qtde, uniMedida_cod, categoria_cod) " +
                            "VALUES (@nome, @desc, @pago, @venda, @quant, @unidade, @categoria)";
                        }

                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@nome", modelo.NomeProduto));
                        comm.Parameters.Add(new SqlParameter("@desc", modelo.DescricaoProduto));
                        comm.Parameters.Add(new SqlParameter("@pago", modelo.ValorPagoProduto));
                        comm.Parameters.Add(new SqlParameter("@venda", modelo.ValorVendaProduto));
                        comm.Parameters.Add(new SqlParameter("@quant", modelo.QuantProduto));
                        comm.Parameters.Add(new SqlParameter("@unidade", modelo.CodigoUnidadeMedida));
                        comm.Parameters.Add(new SqlParameter("@categoria", modelo.CodigoCategoria));
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
