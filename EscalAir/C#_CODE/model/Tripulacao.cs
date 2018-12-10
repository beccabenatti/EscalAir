using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class Tripulacao
    {
        private int id;
        private int idPiloto;
        private int idCopiloto;
        private int idComissarioChefe;
        private int idComissarioUm;
        private int idComissarioDois;
        private int idVoo;

        public void inserirTripulacao(SqlConnection connection)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Tripulacao (idPiloto, idCopiloto, idComissarioChefe, idComissarioUm, idComissarioDois) VALUES (@idPiloto_PARAM, @idCopiloto_PARAM, @idComissarioChefe_PARAM, @idComissarioUm_PARAM, @idComissarioDois_PARAM)";
                    cmd.Parameters.AddWithValue("@idPiloto_PARAM", idPiloto);
                    cmd.Parameters.AddWithValue("@idCopiloto_PARAM", idCopiloto);
                    cmd.Parameters.AddWithValue("@idComissarioChefe_PARAM", idComissarioChefe);
                    cmd.Parameters.AddWithValue("@idComissarioUm_PARAM", idComissarioUm);
                    cmd.Parameters.AddWithValue("@idComissarioDois_PARAM", idComissarioDois);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public int getLastIdTripulacao(SqlConnection connection)
        {
            int lastIdVoo = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT TOP 1 id FROM Tripulacao ORDER BY id DESC";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lastIdVoo = reader.GetInt32(0);
                        }

                        reader.Close();
                        return lastIdVoo;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return lastIdVoo;
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
        public int getIdPiloto()
        {
            return idPiloto;
        }
        public void setIdPiloto(int idPiloto)
        {
            this.idPiloto = idPiloto;
        }
        public int getIdCopiloto()
        {
            return idCopiloto;
        }
        public void setIdCopiloto(int idCopiloto)
        {
            this.idCopiloto = idCopiloto;
        }
        public int getIdComissarioChefe()
        {
            return idComissarioChefe;
        }
        public void setIdComissarioChefe(int idComissarioChefe)
        {
            this.idComissarioChefe = idComissarioChefe;
        }
        public int getIdComissarioUm()
        {
            return idComissarioUm;
        }
        public void setIdComissarioUm(int idComissarioUm)
        {
            this.idComissarioUm = idComissarioUm;
        }
        public int getIdComissarioDois()
        {
            return idComissarioDois;
        }
        public void setIdComissarioDois(int idComissarioDois)
        {
            this.idComissarioDois = idComissarioDois;
        }
        public int getIdVoo()
        {
            return idVoo;
        }
        public void setIdVoo(int idVoo)
        {
            this.idVoo = idVoo;
        }
    }
}
