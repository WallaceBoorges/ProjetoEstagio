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
    public class DALProduto
    {
        /*
        public static DataTable LocalizarDados(String valor)
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "Select sub.*, cate.categoria_nome from subcategoria as sub " +
                        "inner join categoria as cate on sub.categoria_cod = cate.categoria_cod " +
                        "WHERE subcategoria_nome LIKE @nome order by subcategoria_cod desc";
                    //Passando valores por parametro
                    comm.Parameters.Add(new SqlParameter("@nome", valor + "%"));
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }
        */

        /* Método para carregar os dados da tabela no DataGridView*/
        /*
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
        

        public static void Excluir(int codigo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "DELETE FROM categoria WHERE categoria_cod = @id";
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

        public static void Incluir(MProduto modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "Insert into produto(categoria_cod, subCategoria_cod, uniMedida_cod, produto_nome" +
                            "produto_descricao, produto_foto, produto_valorpago, produto_valorvenda, " +
                            "produto_qtde) " +
                            "values (@procod, @unimedcod, @catcod, @scatcod " +
                            "@nome, @descricao, @foto, @valorpago, @valorvenda, " +
                            "@qtde); select @@IDENTITY;"
;                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@nome", modelo.produto_nome));
                        comm.Parameters.Add(new SqlParameter("@descricao", modelo.produto_descricao));
                        comm.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                        if(modelo.produto_foto == null)
                        {
                            comm.Parameters["@foto"].Value = DBNull.Value;
                        }
                        else
                        {
                            comm.Parameters["@foto"].Value = modelo.produto_foto;
                        }
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

        public static void Alterar(MCategoria modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao())//Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "Update categoria set categoria_nome = @nome where categoria_cod = @codigo;";
                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@nome", modelo.categoria_nome));
                        comm.Parameters.Add(new SqlParameter("@codigo", modelo.categoria_cod));
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
        */
    }
}
