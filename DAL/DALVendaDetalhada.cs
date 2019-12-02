using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DALVendaDetalhada
    {
        public static DataTable CarregarParcelas(int cod)
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    //comm.CommandText = "Select* from parcelasvenda order by categoria_cod desc";
                    comm.CommandText = "Select* from parcelasvenda where venda_cod = " + cod + " order by parcelasVenda_tadavecto asc";
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }

        public static DataTable CarregarItens(int cod)
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    //comm.CommandText = "Select* from categoria order by categoria_cod desc";
                    comm.CommandText = "SELECT i.itensVenda_qtde, i.itensVenda_valor, p.produto_nome FROM itensvenda AS i LEFT JOIN produto AS p ON (i.produto_cod = p.produto_cod) WHERE venda_cod = " + cod;
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }
        public static String[] CarregarCampos(int cod)
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    //comm.CommandText = "Select* from categoria order by categoria_cod desc";
                    comm.CommandText = "Select v.venda_data, v.venda_nfiscal, v.venda_total, " +
                        "v.venda_taxaParcela, v.venda_status, c.cliente_nome, p.tipoPag_nome, f.fun_nome " +
                        " FROM venda AS v LEFT JOIN cliente AS c ON (v.cliente_cod = c.cliente_cod) " +
                        "LEFT JOIN tipopagamento AS p ON (v.tipoPag_cod = p.tipoPag_cod) " +
                        "LEFT JOIN funcionario AS f ON (v.fun_cod = f.fun_cod) WHERE venda_cod = " + cod;
                    var reader = comm.ExecuteReader(); //Passando o comando
                    reader.Read();
                    String[] dados = new String[8];
                    dados[0] = reader.GetDateTime(0).ToString("MM/dd/yyyy");//venda_data
                    dados[1] = reader.GetString(1);//venda_nfiscal
                    dados[2] = reader.GetDecimal(2).ToString();//venda_total
                    dados[3] = reader.GetValue(3).ToString();//venda_taxaParcela
                    dados[4] = reader.GetString(4);//venda_status
                    dados[5] = reader.GetValue(5).ToString();//cliente_nome
                    dados[6] = reader.GetString(6);//tipoPag_nome
                    dados[7] = reader.GetString(7);//fun_nome
                    return dados;
                }
            }
        }
    }
}
