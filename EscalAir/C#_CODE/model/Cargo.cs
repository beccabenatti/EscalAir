using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class Cargo
    {
        private int id;
        private string descricao;


        public List<Cargo> carregarCargos (SqlConnection connection)
        {
            List<Cargo> lista = new List<Cargo>();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT id, descricao FROM Cargos";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cargo temp = new Cargo();
                            temp.id = reader.GetInt32(0);
                            temp.descricao = reader.GetString(1);
                            lista.Add(temp);
                        }

                        reader.Close();
                        return lista;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public void inserirCargo(SqlConnection connection)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Cargos (descricao) VALUES (@descricao_PARAM)";
                    cmd.Parameters.AddWithValue("@descricao_PARAM", descricao);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getDescricao()
        {
            return descricao;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

    }
}
