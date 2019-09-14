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
    public class DALUnidadeMedida
    {
        //Método para carregar os dados do banco no combobox da unidade de medida 
        public static DataTable CarregarGrid()
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "Select* from undmedida order by uniMedida_cod desc";
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }

        /*Optei por deixar tudo comentado pq se caso a gente precise desses métodos algum dia, é só tirar do
         * do comentário 
         Os métodos abaixo são referentes ao CRUD.*/
       
        
        /*public static DataTable LocalizarDados(String valor)
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "Select* from undmedida WHERE uniMedida_nome LIKE @nome";
                    //Passando valores por parametro
                    comm.Parameters.Add(new SqlParameter("@nome", valor + "%"));
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }

        /*
        public static void Excluir(int codigo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "DELETE FROM undmedida WHERE uniMedida_cod = @id";
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

        public static void Incluir(MUnidadeMedida modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "INSERT INTO undMedida (uniMedida_nome) VALUES (@nome)";
                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@nome", modelo.nomeUniMedida));
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

        public static void Alterar(MUnidadeMedida modelo)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao())//Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {
                        comm.CommandText = "Update undmedida set uniMedida_nome = @nome where uniMedida_cod = @codigo;";
                        //Passando valores por parametro
                        comm.Parameters.Add(new SqlParameter("@nome", modelo.nomeUniMedida));
                        comm.Parameters.Add(new SqlParameter("@codigo", modelo.codigoUniMedida));
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
