using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class Empresa
    {
        private int id;
        private string nomeEmpresa;

        public Empresa carregarEmpresa(SqlConnection connection, int id)
        {
            Empresa temp = new Empresa();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT TOP 1 id, nomeEmpresa FROM Empresa WHERE id=@id_PARAM";
                    cmd.Parameters.AddWithValue("@id_PARAM", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp.id = reader.GetInt32(0);
                            temp.nomeEmpresa = reader.GetString(1);
                        }

                        reader.Close();
                        return temp;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }

        }

        public List<Empresa> carregarEmpresas(SqlConnection connection)
        {
            List<Empresa> lista = new List<Empresa>();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT id, nomeEmpresa FROM Empresa";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empresa temp = new Empresa();
                            temp.id = reader.GetInt32(0);
                            temp.nomeEmpresa = reader.GetString(1);
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

        public void inserirEmpresa(SqlConnection connection)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Empresa (nomeEmpresa) VALUES (@nomeEmpresa_PARAM)";
                    cmd.Parameters.AddWithValue("@nomeEmpresa_PARAM", nomeEmpresa);
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


        public string getNomeEmpresa()
        {
            return nomeEmpresa;
        }


        public void setNomeEmpresa(string nomeEmpresa)
        {
            this.nomeEmpresa = nomeEmpresa;
        }

    }
}
