using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class Endereco
    {
        private int idUsuario;
        private string estado;
        private string cidade;
        private string bairro;
        private string rua;
        private int numero;

        public void inserirEndereco(SqlConnection connection)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Endereco (idUsuario, estado, cidade, bairro, rua, numero) VALUES (@idUsuario_PARAM, @estado_PARAM, @cidade_PARAM, @rua_PARAM, @bairro_PARAM, @numero_PARAM)";
                    cmd.Parameters.AddWithValue("@idUsuario_PARAM", idUsuario);
                    cmd.Parameters.AddWithValue("@estado_PARAM", estado);
                    cmd.Parameters.AddWithValue("@cidade_PARAM", cidade);
                    cmd.Parameters.AddWithValue("@bairro_PARAM", bairro);
                    cmd.Parameters.AddWithValue("@rua_PARAM", rua);
                    cmd.Parameters.AddWithValue("@numero_PARAM", numero);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public int getIdUsuario()
        {
            return idUsuario;
        }
        public void setIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }
        public string getEstado()
        {
            return estado;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        public string getCidade()
        {
            return cidade;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public string getBairro()
        {
            return bairro;
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public string getRua()
        {
            return rua;
        }
        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public int getNumero()
        {
            return numero;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
    }
}
