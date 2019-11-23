using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALFuncionario
    {
        /* Método para carregar os dados da tabela no DataGridView*/
        public static DataTable CarregarGrid()
        {
            using (var conn = ConexaoBD.AbrirConexao()) //Passando a string de conexão
            {
                conn.Open(); //Abrindo a conexão
                using (var comm = conn.CreateCommand()) //Criando o comando SQL
                {
                    comm.CommandText = "SELECT funci.*, ende.endereco_cep, ende.endereco_logradouro, ende.endereco_bairro, ende.endereco_numero, ende.endereco_cidade, ende.endereco_estado " +
                        "FROM funcionario as funci " +
                        "inner join endereco as ende on funci.endereco_cod = ende.endereco_cod";
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
                    comm.CommandText = "SELECT * FROM funcionario as forn inner join endereco as ende on " +
                        " forn.endereco_cod = ende.endereco_cod WHERE forn.fun_nome LIKE @nome order by forn.fun_cod desc";

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
        public static void Alterar(MFuncionario modelo, MEndereco endereco)
        {
            try
            {
                using (var conn = ConexaoBD.AbrirConexao()) //Passando string de conexão
                {
                    conn.Open(); //Abrindo conexao
                    using (var comm = conn.CreateCommand()) //CRiando comando SQL
                    {
                        comm.CommandText = "update funcionario set fun_nome = @nome, fun_usuario = @usuario, fun_senha = @senha, fun_cpf = @cpf, fun_rg = @rg, fun_datanascimento = @datanascimento, fun_sexo = @sexo, fun_estadocivil = @estadocivil, fun_celular = @celular, fun_funcaoexercida = @funcaoexercida, fun_admissao = @admissao, fun_demissao = @demissao, fun_salariobase = @salariobase, fun_banconome = @banconome, fun_bancoagencia = @bancoagencia, fun_bancoconta = @bancoconta, where fun_cod = @codigo ";

                        comm.Parameters.Add(new SqlParameter("@nome", modelo.NomeFuncionario));
                        comm.Parameters.Add(new SqlParameter("@usuario", modelo.UsuarioFuncionario));
                        comm.Parameters.Add(new SqlParameter("@senha", modelo.SenhaFuncionario));
                        comm.Parameters.Add(new SqlParameter("@cpf", modelo.CpfFuncionario));
                        comm.Parameters.Add(new SqlParameter("@rg", modelo.RgFuncionario));
                        comm.Parameters.Add(new SqlParameter("@datanascimento", modelo.DataNascimentoFuncionario));
                        comm.Parameters.Add(new SqlParameter("@sexo", modelo.SexoFuncionario));
                        comm.Parameters.Add(new SqlParameter("@estadocivil", modelo.EstadoCivilFuncionario));
                        comm.Parameters.Add(new SqlParameter("@celular", modelo.CelularFuncionario));
                        comm.Parameters.Add(new SqlParameter("@funcaoexercida", modelo.FuncaoExercidaFuncionario));
                        comm.Parameters.Add(new SqlParameter("@admissao", modelo.AdmissaoFuncionario));
                        comm.Parameters.Add(new SqlParameter("@demissao", modelo.DemissaoFuncionario));
                        comm.Parameters.Add(new SqlParameter("@salariobase", modelo.SalarioBaseFuncionario));
                        comm.Parameters.Add(new SqlParameter("@banconome", modelo.BancoNomeFuncionario));
                        comm.Parameters.Add(new SqlParameter("@bancoagencia", modelo.BancoAgenciaFuncionario));
                        comm.Parameters.Add(new SqlParameter("@bancoconta", modelo.BancoContaFuncionario));
                        comm.Parameters.Add(new SqlParameter("@codigo", modelo.CodigoFuncionario));

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
        public static void Incluir(MFuncionario modelo, MEndereco endereco)
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
                        comm.CommandText = "INSERT INTO funcionario (fun_nome, fun_usuario, fun_senha, fun_cpf, fun_rg, fun_datanascimento, fun_sexo, fun_estadocivil, fun_celular, fun_funcaoexercida, fun_admissao, fun_salariobase, fun_banconome, fun_bancoagencia, fun_bancoconta, " +
                            "endereco_cod) VALUES (@nome, @usuario, @senha, @cpf, @rg, @datanascimento, @sexo, @estadocivil, @celular, @funcaoexercida, @admissao, @salariobase, @banconome, @bancoagencia, @bancoconta, (Select TOP 1 endereco_cod from endereco order by endereco_cod desc)) ";
                        comm.Parameters.Add(new SqlParameter("@nome", modelo.NomeFuncionario));
                        comm.Parameters.Add(new SqlParameter("@usuario", modelo.UsuarioFuncionario));
                        comm.Parameters.Add(new SqlParameter("@senha", modelo.SenhaFuncionario));
                        comm.Parameters.Add(new SqlParameter("@cpf", modelo.CpfFuncionario));
                        comm.Parameters.Add(new SqlParameter("@rg", modelo.RgFuncionario));
                        comm.Parameters.Add(new SqlParameter("@datanascimento", modelo.DataNascimentoFuncionario));
                        comm.Parameters.Add(new SqlParameter("@sexo", modelo.SexoFuncionario));
                        comm.Parameters.Add(new SqlParameter("@estadocivil", modelo.EstadoCivilFuncionario));
                        comm.Parameters.Add(new SqlParameter("@celular", modelo.CelularFuncionario));
                        comm.Parameters.Add(new SqlParameter("@funcaoexercida", modelo.FuncaoExercidaFuncionario));
                        comm.Parameters.Add(new SqlParameter("@admissao", modelo.AdmissaoFuncionario));
                        comm.Parameters.Add(new SqlParameter("@salariobase", modelo.SalarioBaseFuncionario));
                        comm.Parameters.Add(new SqlParameter("@banconome", modelo.BancoNomeFuncionario));
                        comm.Parameters.Add(new SqlParameter("@bancoagencia", modelo.BancoAgenciaFuncionario));
                        comm.Parameters.Add(new SqlParameter("@bancoconta", modelo.BancoContaFuncionario));
                        comm.Parameters.Add(new SqlParameter("@codigo", modelo.CodigoFuncionario));

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
                        comm.CommandText = "Delete funcionario where fun_cod = @codigo";
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
