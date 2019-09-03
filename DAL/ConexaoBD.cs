using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexaoBD
    {
        public static IDbConnection AbrirConexao()
        {
            return new SqlConnection("Data Source=LAPTOP-3E6S24H8\\SQLEXPRESS;Initial Catalog=ProjetoEstagio;Integrated Security=True");
        }
    }

}
