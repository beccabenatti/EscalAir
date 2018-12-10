using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER
{
    class ConnectionFactory
    {
        public static SqlConnection getConnection () {
            SqlConnection conexao = new SqlConnection("Server= localhost;Database=EscalAir;User Id=sa;Password = ifsp;");
            conexao.Open();
            SqlCommand comando = new SqlCommand("SET DATEFORMAT ymd;", conexao);
            comando.ExecuteNonQuery();
            return conexao;
        }
    }
}
