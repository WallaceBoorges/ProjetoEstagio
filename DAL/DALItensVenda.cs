using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALItensVenda
    {
        public static void Incluir(MItensVenda modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {

                        comm.CommandText = "INSERT INTO itensvenda(itensVenda_qtde, itensVenda_valor, venda_cod, produto_cod)" +
                            " VALUES (@quant, @valor, @vendcod, @prodcod)";

                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@quant", modelo.ItensVendaQuant));
                        comm.Parameters.Add(new SqlParameter("@valor", modelo.ItensVendaValor));
                        comm.Parameters.Add(new SqlParameter("@vendcod", modelo.VendaCod));
                        comm.Parameters.Add(new SqlParameter("@prodcod", modelo.Produto.CodigoProduto));
                        //Executando o comando
                        comm.ExecuteNonQuery();

                        //Diminuindo do estoque
                        comm.CommandText = "UPDATE produto SET produto_qtde = @novaquant WHERE produto_cod = @prodid";

                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@novaquant", modelo.Produto.QuantProduto - modelo.ItensVendaQuant));
                        comm.Parameters.Add(new SqlParameter("@prodid", modelo.Produto.CodigoProduto));
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
