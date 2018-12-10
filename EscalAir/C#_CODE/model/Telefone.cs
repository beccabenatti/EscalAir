using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class Telefone
    {
        private int idTelefone;
        private int idUsuario;
        private string telefone;

        public void inserirTelefone(SqlConnection connection)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Telefone (idUsuario, telefone) VALUES (@idUsuario_PARAM, @telefone_PARAM)";
                    cmd.Parameters.AddWithValue("@idUsuario_PARAM", idUsuario);
                    cmd.Parameters.AddWithValue("@telefone_PARAM", telefone);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public int getIdTelefone()
        {
            return idTelefone;
        }
        public void setIdTelefone(int idTelefone)
        {
            this.idTelefone = idTelefone;
        }
        public int getIdUsuario()
        {
            return idUsuario;
        }
        public void setIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
    }
}
