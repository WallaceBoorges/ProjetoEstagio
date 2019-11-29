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
    public class DALCliente
    {
        /* Método para carregar os dados da tabela no DataGridView*/
        public static DataTable CarregarGrid()
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "SELECT forn.*, ende.endereco_cep, ende.endereco_logradouro, ende.endereco_bairro, ende.endereco_numero, ende.endereco_cidade, ende.endereco_estado FROM cliente as forn inner join endereco as ende on forn.endereco_cod = ende.endereco_cod";
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }


        public static DataTable LocalizarDados(String valor)
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "SELECT * FROM  cliente as forn inner join endereco as ende on " +
                        " forn.endereco_cod = ende.endereco_cod WHERE forn.cliente_nome LIKE @nome order by forn.cliente_cod desc";

                    //Passando valores por parametro
                    comm.Parameters.Add(new SqlParameter("@nome", valor + "%"));
                    var reader = comm.ExecuteReader(); //Passando o comando 
                    var table = new DataTable(); //Passando a tabela
                    table.Load(reader); //Carregando a tabela 
                    return table; //Retornando a consulta ao Banco de Dados
                }
            }
        }

        /*No alterar foi feito o mesmo que o incluir, primeiro eu altero o campo fornecedor, limpo os parametros e depois
         faço a alteração no campo endereço.*/
        public static void Alterar(MCliente modelo, MEndereco endereco)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando string de conexão
                {
                    conn.Open(); //Abrindo conexao
                    using (var comm = conn.CreateCommand()) //CRiando comando SQL
                    {
                        comm.CommandText = "update cliente set cliente_nome = @nome, cliente_tipo = @tipo, cliente_rg = @rg, cliente_cpfcnpj = @cpfcnpj, cliente_rsocial = @rsocial, "
                                + " cliente_fone = @fone, "
                                + "cliente_cel = @cel, cliente_email = @email where cliente_cod = @codigo ";



                        comm.Parameters.Add(new SqlParameter("@nome", modelo.NomeCliente));
                        comm.Parameters.Add(new SqlParameter("@tipo", modelo.TipoCliente));
                        comm.Parameters.Add(new SqlParameter("@rg", modelo.RgCliente));
                        comm.Parameters.Add(new SqlParameter("@cpfcnpj", modelo.CpfCliente));
                        comm.Parameters.Add(new SqlParameter("@rsocial", modelo.RsocialCliente));
                        comm.Parameters.Add(new SqlParameter("@fone", modelo.FoneCliente));
                        comm.Parameters.Add(new SqlParameter("@cel", modelo.CelCliente));
                        comm.Parameters.Add(new SqlParameter("@email", modelo.EmailCliente));
                        comm.Parameters.Add(new SqlParameter("@codigo", modelo.CodigoCliente));

                        //Executando comando

                        comm.ExecuteNonQuery();
                        comm.Parameters.Clear();

                        comm.CommandText = "update endereco set endereco_cep = @cep, endereco_logradouro = @logradouro, endereco_bairro = @bairro, " +
                                "endereco_numero = @numero, endereco_cidade = @cidade, endereco_estado = @estado where endereco_cod = @codigo";

                        comm.Parameters.Add(new SqlParameter("@cep", endereco.CepEndereco));
                        comm.Parameters.Add(new SqlParameter("@logradouro", endereco.LogradouroEndereco));
                        comm.Parameters.Add(new SqlParameter("@bairro", endereco.BairroEndereco));
                        comm.Parameters.Add(new SqlParameter("@numero", endereco.NumeroEndereco));
                        comm.Parameters.Add(new SqlParameter("@cidade", endereco.CidadeEndereco));
                        comm.Parameters.Add(new SqlParameter("@estado", endereco.EstadoEndereco));
                        comm.Parameters.Add(new SqlParameter("@codigo", endereco.CodigoEndereco));


                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
        /*Aqui está sendo passado o Modelo Endereco como paramêtro para a inclusão dessa tabela
         seja feita através da tela de forncedor.*/
        public static void Incluir(MCliente modelo, MEndereco endereco)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
                {
                    conn.Open(); //Abrindo a conexão
                    using (var comm = conn.CreateCommand()) //Criando o comando SQL
                    {

                        /*Primeiro faz INSERT na tabela endereco, que é chave estrangeira em fornecedor...*/

                        comm.CommandText = @"INSERT INTO endereco (endereco_cep, endereco_logradouro, endereco_bairro, 
                        endereco_numero, endereco_cidade, endereco_estado) VALUES (@cep, @logradouro, 
                         @bairro, @numero, @cidade, @estado)";

                        //Passando valores por parametro

                        comm.Parameters.Add(new SqlParameter("@cep", endereco.CepEndereco));
                        comm.Parameters.Add(new SqlParameter("@logradouro", endereco.LogradouroEndereco));
                        comm.Parameters.Add(new SqlParameter("@bairro", endereco.BairroEndereco));
                        comm.Parameters.Add(new SqlParameter("@numero", endereco.NumeroEndereco));
                        comm.Parameters.Add(new SqlParameter("@cidade", endereco.CidadeEndereco));
                        comm.Parameters.Add(new SqlParameter("@estado", endereco.EstadoEndereco));


                        //Executando o comando
                        comm.ExecuteNonQuery();
                        /*Limpa todos os parâmetros para que a variável comm receba os valores
                         da para inserir em fornecedor. Caso não limpe, não será possível inserir em 
                         fornecedor.*/
                        comm.Parameters.Clear();

                        /*Depois que insere em endereco, agora podemos inserir em fornecedor.
                         Nessa string de conexão, ao invés de chamar o id de endereco, passando uma variável para receber 
                         o id, é chamado um select para puxar o ultimo cadastro em endereco, que foi o cadastro que foi feito 
                         anteriormente. Esse cadastro será relacionado ao cadastro do fornecedor.*/
                        comm.CommandText = "INSERT INTO cliente (cliente_nome, cliente_tipo, cliente_cpfcnpj, cliente_rg, cliente_rsocial, " +
                                "cliente_fone, cliente_cel, cliente_email, " +
                                "endereco_cod) VALUES (@nome, @tipo, @cpfcnpj, @rg, @rsocial, @fone, @cel, @email, (Select TOP 1 endereco_cod from endereco order by endereco_cod desc)) ";
                        comm.Parameters.Add(new SqlParameter("@nome", modelo.NomeCliente));
                        comm.Parameters.Add(new SqlParameter("@tipo", modelo.TipoCliente));
                        comm.Parameters.Add(new SqlParameter("@cpfcnpj", modelo.CpfCliente));
                        comm.Parameters.Add(new SqlParameter("@rg", modelo.RgCliente));
                        comm.Parameters.Add(new SqlParameter("@rsocial", modelo.RsocialCliente));
                        comm.Parameters.Add(new SqlParameter("@fone", modelo.FoneCliente));
                        comm.Parameters.Add(new SqlParameter("@cel", modelo.CelCliente));
                        comm.Parameters.Add(new SqlParameter("@email", modelo.EmailCliente));
                        comm.Parameters.Add(new SqlParameter("@codigo", modelo.CodigoCliente));

                        comm.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
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
                        comm.CommandText = "Delete cliente where cliente_cod = @codigo";
                        //Passando o valores por parametro
                        comm.Parameters.Add(new SqlParameter("@codigo", codigo));
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

