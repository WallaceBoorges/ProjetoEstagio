using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;

namespace DAL
{
    public class ConexaoBD
    {
        public string TipoConexao { get; set; }
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        //Metodo construtor
        public ConexaoBD()
        {
            //Analisando os possíveis erros de conexão com o Banco de dado
            if (System.IO.File.Exists("Configuração Banco.txt") != false)
            {
                //Abrindo o arquivo com as configurações da conexão ao banco
                using (StreamReader ConfBanco = new StreamReader("Configuração Banco.txt"))
                {
                    TipoConexao = ConfBanco.ReadLine();
                    Servidor = ConfBanco.ReadLine();
                    Banco = ConfBanco.ReadLine();
                    if (TipoConexao == "Remota")
                    {
                        Senha = ConfBanco.ReadLine();
                        Usuario = ConfBanco.ReadLine();
                    }
                }
            }
            else
            {
                throw new IOException("Arquivo de configuração não foi encontrado, por favor configure a conexão!");
            }
        }




        //Metodo para testar conexão e chamar o formulario que salva as configurações do banco
        public static void TesteConexao()
        {
            //Analisando os possíveis erros de conexão com o Banco de dado
            if (System.IO.File.Exists("Configuração Banco.txt") == false)
            {
                throw new IOException("Arquivo de configuração não foi encontrado, por favor configure a conexão!");
            }
            else
            {
                //Testando a conexão com o banco
                try
                {
                    using (var conn = AbrirConexao()) //Abringo Conexão
                    {
                        conn.Open();
                    }
                }
                catch (IOException) //Erro com o arquivo
                {
                    throw new IOException("Erro com o Arquivo de Configuração, salve os dados e tente novamente");
                }
                catch (SqlException) //Erro de conexão
                {
                    throw new IOException("Erro com a conexão");
                }
            }
        }

        public static IDbConnection AbrirConexao()
        {
            IDbConnection conexao;

            string tipo = "";
            string servidor = "";
            string banco = "";
            string usuario = "";
            string senha = "";

            //Abrindo o arquivo com as configurações da conexão ao banco
            using (StreamReader ConfBanco = new StreamReader("Configuração Banco.txt"))
            {
                tipo = ConfBanco.ReadLine();
                servidor = ConfBanco.ReadLine();
                banco = ConfBanco.ReadLine();
                if (tipo == "Remota")
                {
                    senha = ConfBanco.ReadLine();
                    usuario = ConfBanco.ReadLine();
                }
            }

            //Analisando se o arquivo tá vazio
            if (tipo == "" || servidor == "" || banco == "")
            {
                throw new Exception("O arquivo de configuração do banco está vazio, salve as informações necessárias");
            }

            //Analisando o tipo de conexão para retonar a string correta
            if (tipo == "Remota")
            {
                conexao = new SqlConnection("Data Source=" + servidor + ";Initial Catalog=" + banco + ";Persist Security Info=True;User ID= " + usuario + ";Password=" + senha + ";"); //Retornando a String de Conexãos
                conexao.Open();
                conexao.Close();
                return conexao;
            }
            else
            {
                conexao = new SqlConnection("Data Source=" + servidor + ";Initial Catalog=" + banco + ";Integrated Security=True"); //Retornando a String de Conexãos
                conexao.Open();
                conexao.Close();
                return conexao;
            }

            //STRING DE WALLACE
            //return new SqlConnection("Data Source=LAPTOP-3E6S24H8\\SQLEXPRESS;Initial Catalog=ProjetoEstagio;Integrated Security=True");

            //STRING DE MATHEUS
            //return new SqlConnection("Data Source=NAVE;Initial Catalog=ProjetoEstagio;Integrated Security=True");

            //STRING DE EVERTON
            //return new SqlConnection("Data Source=DESKTOP-36O4NH1\\SQLEXPRESS;Initial Catalog=ProjetoEstagio;Integrated Security=True");
            //return new SqlConnection("Data Source=\\SQLEXPRESS;Initial Catalog=ProjetoEstagio;Integrated Security=True");
            //return new SqlConnection("Data Source=SQLEXPRESS;Initial Catalog=ProjetoEstagio;Integrated Security=True");

            //STRING DE PALOMA
            //return new SqlConnection("Data Source=LAPTOP-K7T1BIJL;Initial Catalog=ProjetoEstagio;Integrated Security=True");

            //STRING DE ISAQUE
            //return new SqlConnection("Data Source=THE-ELDER-PC\\SQLEXPRESS;Initial Catalog=ProjetoEstagio;Integrated Security=True");
        }


        //Funções responsáveis por restaurar o BD
        public void RestaurarDBPadraoCasoNaoExista()
        {
            try
            {
                var bancoExiste = VerificaSeBancoJaExiste(); //Verificando se o banco existe

                if (!bancoExiste)
                {
                    RestaurarDBPadrao(); //Restaurando o Banco                
                }

                TesteConexao(); //Restando a conexão
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Função que verifica a existencia do BD
        public bool VerificaSeBancoJaExiste()
        {
            bool retorno = false; //Criando variavel com o valor de retorno 

            try
            {
                if (TipoConexao == "Local")
                {
                    using (var conn = new System.Data.SqlClient.SqlConnection(@"Data Source=" + Servidor + ";Initial Catalog=master;Integrated Security=True;")) //Passando a String de conexão
                    {
                        conn.Open(); //Abrindo a conexão com o BD
                        using (var comm = conn.CreateCommand()) //Criando uma variavel para armazenar os comandos e executa-los
                        {
                            comm.CommandText = "SELECT 1 FROM SYS.DATABASES WHERE NAME LIKE 'ProjetoEstagio'"; //Passando os comandos
                            var valor = comm.ExecuteScalar(); //Pasando o resultado da execução 
                                                              //Analisando o resultado
                            if (valor != null && valor != DBNull.Value && Convert.ToInt32(valor).Equals(1))
                            {
                                retorno = true;
                            }
                        }
                    }
                }
                else //Conexão Remota
                {
                    using (var conn = new System.Data.SqlClient.SqlConnection(@"Data Source=" + Servidor + ";Initial Catalog=master;Persist Security Info=True;User ID= " + Usuario + ";Password=" + Senha + ";")) //Passando a String de conexão
                    {
                        conn.Open(); //Abrindo a conexão com o BD
                        using (var comm = conn.CreateCommand()) //Criando uma variavel para armazenar os comandos e executa-los
                        {
                            comm.CommandText = "SELECT 1 FROM SYS.DATABASES WHERE NAME LIKE 'ProjetoEstagio'"; //Passando os comandos
                            var valor = comm.ExecuteScalar(); //Pasando o resultado da execução 
                                                              //Analisando o resultado
                            if (valor != null && valor != DBNull.Value && Convert.ToInt32(valor).Equals(1))
                            {
                                retorno = true;
                            }
                        }
                    }
                }

                if (retorno == false && TipoConexao != "Local") //Analisando se o banco não existe e se ele é remoto
                {
                    throw new Exception("BANCO NÃO EXISTE!\nNão é possivel realizar restauração para conexão remota");
                }
            }
            catch (SqlException)
            {
                throw new IOException("Erro de Conexão"); //Mensagem de erro caso exista
            }
            catch (Exception)
            {
                throw new Exception("Erro ao verificar se o banco exite ou não"); //Mensagem de erro caso exista
            }

            return retorno; //Retornando o valorr resultado 
        }
        //Pegando os diretorios padrões 
        public void DescobrirDiretoriosPadrao(out String diretorioDados, out string diretorioLog, out string diretorioBackup)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(@"Data Source=" + Servidor + ";Initial Catalog=master;Integrated Security=True;"))
            {
                var serverConnection = new Microsoft.SqlServer.Management.Common.ServerConnection(connection);
                var server = new Microsoft.SqlServer.Management.Smo.Server(serverConnection);
                diretorioDados = !string.IsNullOrWhiteSpace(server.Settings.DefaultFile) ? server.Settings.DefaultFile : (!string.IsNullOrWhiteSpace(server.DefaultFile) ? server.DefaultFile : server.MasterDBPath);
                diretorioLog = !string.IsNullOrWhiteSpace(server.Settings.DefaultLog) ? server.Settings.DefaultLog : (!string.IsNullOrWhiteSpace(server.DefaultLog) ? server.DefaultLog : server.MasterDBLogPath);
                diretorioBackup = !string.IsNullOrWhiteSpace(server.Settings.BackupDirectory) ? server.Settings.BackupDirectory : server.BackupDirectory;
            }
        }
        //Restaurando o BD
        public void RestaurarDBPadrao()
        {
            try
            {
                string diretorioDados, diretorioLog, diretorioBackup;
                DescobrirDiretoriosPadrao(out diretorioDados, out diretorioLog, out diretorioBackup); //Recebendo os diretorio necessários 

                using (var conn = new System.Data.SqlClient.SqlConnection(@"Data Source=" + Servidor + ";Initial Catalog=master;Integrated Security=True;")) //Passando a string de conexão
                {
                    conn.Open(); //Acrindo conexão
                    using (var comm = conn.CreateCommand()) //Criando variavel responsável por armazenar e executar os comandos
                    {
                        //Comandos
                        var caminhoCompletoBackup = System.IO.Path.Combine(diretorioBackup, "ProjetoEstagio.bak");
                        var caminhoCompletoDados = System.IO.Path.Combine(diretorioDados, "ProjetoEstagio.mdf");
                        var caminhoCompletoLog = System.IO.Path.Combine(diretorioLog, "ProjetoEstagio_Log.ldf");
                        System.IO.File.Copy("ProjetoEstagio.bak", caminhoCompletoBackup, true);
                        comm.CommandText =
                            @"RESTORE DATABASE ProjetoEstagio " +
                            @"FROM DISK = N'" + caminhoCompletoBackup + "' " +
                            @"WITH FILE = 1, " +
                            @"MOVE N'ProjetoEstagio' TO N'" + caminhoCompletoDados + "', " +
                            @"MOVE N'ProjetoEstagio_LOG' TO N'" + caminhoCompletoLog + "', " +
                            @"NOUNLOAD, REPLACE, STATS = 10";
                        comm.ExecuteNonQuery(); //Executando comando
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao tentar restaurar o banco de dados!"); //Mensagem de erro caso exista
            }
        }


    }

}
