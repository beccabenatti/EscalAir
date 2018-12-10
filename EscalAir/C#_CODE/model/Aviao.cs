using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PROJETO_INTER.model
{

    public class Aviao
    {
        private int id;
        private string tipo;

        public List<Aviao> carregarAvioes(SqlConnection connection)
        {
            List<Aviao> lista = new List<Aviao>();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT id, tipo FROM Aviao";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Aviao temp = new Aviao();
                            temp.id = reader.GetInt32(0);
                            temp.tipo = reader.GetString(1);
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

        public Aviao carregarAviao(SqlConnection connection, int id)
        {
            Aviao temp = new Aviao();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT TOP 1 id, tipo FROM Aviao WHERE id=@id_PARAM";
                    cmd.Parameters.AddWithValue("@id_PARAM", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp.id = reader.GetInt32(0);
                            temp.tipo = reader.GetString(1);
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

        public void inserirAviao(SqlConnection connection)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Aviao (tipo) VALUES (@tipo_PARAM)";
                    cmd.Parameters.AddWithValue("@tipo_PARAM", tipo);
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
        public string getTipo()
        {
            return tipo;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
    }
}