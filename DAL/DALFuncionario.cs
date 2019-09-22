using System.Data;

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
    }
}
