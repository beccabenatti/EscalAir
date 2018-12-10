using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class Voo
    {
        private int id;
        private int aviaoId;
        private string origem;
        private string destino;
        private DateTime horaPartida;
        private DateTime horaChegada;
        private int numeroPassageiros;
        private int tripulacaoId;

        public List<Voo> carregarVoosPorData(SqlConnection connection, DateTime data)
        {
            List<Voo> lista = new List<Voo>();
            DateTime dataLimite = data.AddDays(1);

            string dataParam = data.ToString("yyyy-MM-dd");
            string dataLimiteParam = dataLimite.ToString("yyyy-MM-dd");
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT id, aviaoId, origem, destino, horaPartida, horaChegada, numeroPassageiros FROM Voo WHERE horaPartida BETWEEN @data_PARAM AND @dataLimite_PARAM";
                    cmd.Parameters.AddWithValue("@data_PARAM", dataParam);
                    cmd.Parameters.AddWithValue("@dataLimite_PARAM", dataLimite);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Debug.WriteLine(reader.HasRows + " aaaaaaaaaaa");
                        while (reader.Read())
                        {
                            Voo temp = new Voo();
                            temp.id = reader.GetInt32(0);
                            temp.aviaoId = reader.GetInt32(1);
                            temp.origem = reader.GetString(2);
                            temp.destino = reader.GetString(3);
                            temp.horaPartida = reader.GetDateTime(4);
                            temp.horaChegada = reader.GetDateTime(5);
                            temp.numeroPassageiros = reader.GetInt32(6);
                            lista.Add(temp);
                            Debug.WriteLine(temp.origem);
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

        public void inserirVoo(SqlConnection connection)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Voo (aviaoId, origem, destino, horaPartida, horaChegada, numeroPassageiros, tripulacaoId) VALUES (@aviaoId_PARAM, @origem_PARAM, @destino_PARAM, @horaPartida_PARAM, @ihoraChegada_PARAM, @numeroPassageiros_PARAM, @tripulacaoId_PARAM)";
                    cmd.Parameters.AddWithValue("@aviaoId_PARAM", aviaoId);
                    cmd.Parameters.AddWithValue("@origem_PARAM", origem);
                    cmd.Parameters.AddWithValue("@destino_PARAM", destino);
                    cmd.Parameters.AddWithValue("@horaPartida_PARAM", horaPartida);
                    cmd.Parameters.AddWithValue("@ihoraChegada_PARAM", horaChegada);
                    cmd.Parameters.AddWithValue("@numeroPassageiros_PARAM", numeroPassageiros);
                    cmd.Parameters.AddWithValue("@tripulacaoId_PARAM", tripulacaoId);
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
        public int getAviaoId()
        {
            return aviaoId;
        }
        public void setAviaoId(int aviaoId)
        {
            this.aviaoId = aviaoId;
        }
        public string getOrigem()
        {
            return origem;
        }
        public void setOrigem(string origem)
        {
            this.origem = origem;
        }
        public string getDestino()
        {
            return destino;
        }
        public void setDestino(string destino)
        {
            this.destino = destino;
        }
        public DateTime getHoraPartida()
        {
            return horaPartida;
        }
        public void setHoraPartida(DateTime horaPartida)
        {
            this.horaPartida = horaPartida;
        }
        public DateTime getHoraChegada()
        {
            return horaChegada;
        }
        public void setHoraChegada(DateTime horaChegada)
        {
            this.horaChegada = horaChegada;
        }
        public int getNumeroPassageiros()
        {
            return numeroPassageiros;
        }
        public void setNumeroPassageiros(int numeroPassageiros)
        {
            this.numeroPassageiros = numeroPassageiros;
        }
        public void setTripulacaoId(int tripulacaoId)
        {
            this.tripulacaoId = tripulacaoId;
        }

        public int getTripulacaoId()
        {
            return this.tripulacaoId;
        }
    }
}
