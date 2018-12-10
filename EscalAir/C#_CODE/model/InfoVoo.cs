using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class InfoVoo
    {
        public string Aviao { get; set; }
        public string Origem { get; set; }
        public DateTime HoraDePartida { get; set; }
        public string Destino { get; set; }
        public DateTime HoraDeChegada { get; set; }
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string ComissarioChefe { get; set; }
        public string ComissarioUm { get; set; }
        public string ComissarioDois { get; set; }

        public InfoVoo CarregarVoo (SqlConnection conexao, int @id)
        {
            InfoVoo temp = new InfoVoo();
            try
            {
                string query = "CarregarVoo";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@id", @id));
                using(SqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        temp.setAviao(leitor.GetString(0));
                        temp.setOrigem(leitor.GetString(1));
                        temp.setHoraDePartida(leitor.GetDateTime(2));
                        temp.setDestino(leitor.GetString(3));
                        temp.setHoraDeChegada(leitor.GetDateTime(4));
                        temp.setPiloto(leitor.GetString(5));
                        temp.setCopiloto(leitor.GetString(6));
                        temp.setComissarioChefe(leitor.GetString(7));
                        temp.setComissarioUm(leitor.GetString(8));
                        temp.setComissarioDois(leitor.GetString(9));                
                    }
                    return temp;
                }

            } catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public string getAviao()
        {
            return Aviao;
        }


        public void setAviao(string aviao)
        {
            Aviao = aviao;
        }


        public string getOrigem()
        {
            return Origem;
        }


        public void setOrigem(string origem)
        {
            Origem = origem;
        }


        public DateTime getHoraDePartida()
        {
            return HoraDePartida;
        }


        public void setHoraDePartida(DateTime horaDePartida)
        {
            HoraDePartida = horaDePartida;
        }


        public string getDestino()
        {
            return Destino;
        }


        public void setDestino(string destino)
        {
            Destino = destino;
        }


        public DateTime getHoraDeChegada()
        {
            return HoraDeChegada;
        }


        public void setHoraDeChegada(DateTime horaDeChegada)
        {
            HoraDeChegada = horaDeChegada;
        }


        public string getPiloto()
        {
            return Piloto;
        }


        public void setPiloto(string piloto)
        {
            Piloto = piloto;
        }


        public string getCopiloto()
        {
            return Copiloto;
        }


        public void setCopiloto(string copiloto)
        {
            Copiloto = copiloto;
        }


        public string getComissarioChefe()
        {
            return ComissarioChefe;
        }


        public void setComissarioChefe(string comissarioChefe)
        {
            ComissarioChefe = comissarioChefe;
        }


        public string getComissarioUm()
        {
            return ComissarioUm;
        }


        public void setComissarioUm(string comissarioUm)
        {
            ComissarioUm = comissarioUm;
        }


        public string getComissarioDois()
        {
            return ComissarioDois;
        }


        public void setComissarioDois(string comissarioDois)
        {
            ComissarioDois = comissarioDois;
        }

    }
}
