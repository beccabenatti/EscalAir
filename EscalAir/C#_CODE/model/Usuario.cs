using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class Usuario
    {
        private int id;
        private string cht;
        private string primeiroNome;
        private string sobrenome;
        private string cpf;
        private DateTime dataNascimento;
        private int cargo;
        private string senha;
        private int idEmpresa;

        public void inserirUsuario(SqlConnection connection)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Usuario (cht, primeiroNome, sobrenome, cpf, dataNascimento, cargo, idEmpresa, senha) VALUES (@cht_PARAM, @primeiroNome_PARAM, @sobrenome_PARAM, @cpf_PARAM, @dataNascimento_PARAM, @cargo_PARAM, @idEmpresa_PARAM, @senha_PARAM)";
                    cmd.Parameters.AddWithValue("@cht_PARAM", cht);
                    cmd.Parameters.AddWithValue("@primeiroNome_PARAM", primeiroNome);
                    cmd.Parameters.AddWithValue("@sobrenome_PARAM", sobrenome);
                    cmd.Parameters.AddWithValue("@cpf_PARAM", cpf);
                    cmd.Parameters.AddWithValue("@dataNascimento_PARAM", dataNascimento);
                    cmd.Parameters.AddWithValue("@cargo_PARAM", cargo);
                    cmd.Parameters.AddWithValue("@idEmpresa_PARAM", idEmpresa);
                    cmd.Parameters.AddWithValue("@senha_PARAM", senha);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public Usuario carregarUsuario(SqlConnection connection, int id)
        {
            Usuario temp = new Usuario();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT TOP 1 id, cht, primeiroNome, sobrenome, cpf, dataNascimento, cargo, idEmpresa FROM Usuario WHERE id=@id_PARAM";
                    cmd.Parameters.AddWithValue("@id_PARAM", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp.id = reader.GetInt32(0);
                            temp.cht = reader.GetString(1);
                            temp.primeiroNome = reader.GetString(2);
                            temp.sobrenome = reader.GetString(3);
                            temp.cpf = reader.GetString(4);
                            temp.dataNascimento = reader.GetDateTime(5);
                            temp.cargo = reader.GetInt32(6);
                            temp.idEmpresa = reader.GetInt32(7);
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

        public int getLastIdUsuario (SqlConnection connection)
        {
            int lastIdUsuario = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT TOP 1 id FROM Usuario ORDER BY id DESC";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lastIdUsuario = reader.GetInt32(0);
                        }

                        reader.Close();
                        return lastIdUsuario;
                    }
                } 
            } catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return lastIdUsuario;
            }
        }

        public List<Usuario> carregarUsuarios(SqlConnection connection)
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT id, cht, primeiroNome, sobrenome, cpf, dataNascimento, cargo, idEmpresa FROM Usuario";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario temp = new Usuario();
                            temp.id = reader.GetInt32(0);
                            temp.cht = reader.GetString(1);
                            temp.primeiroNome = reader.GetString(2);
                            temp.sobrenome = reader.GetString(3);
                            temp.cpf = reader.GetString(4);
                            temp.dataNascimento = reader.GetDateTime(5);
                            temp.cargo = reader.GetInt32(6);
                            temp.idEmpresa = reader.GetInt32(7);
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


        public Usuario carregarUsuario(SqlConnection connection, string cht)
        {
            Usuario temp = new Usuario();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT TOP 1 id, cht, primeiroNome, sobrenome, cpf, dataNascimento, cargo, idEmpresa FROM Usuario WHERE cht=@cht_PARAM";
                    cmd.Parameters.AddWithValue("@cht_PARAM", this.cht);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp.id = reader.GetInt32(0);
                            temp.cht = reader.GetString(1);
                            temp.primeiroNome = reader.GetString(2);
                            temp.sobrenome = reader.GetString(3);
                            temp.cpf = reader.GetString(4);
                            temp.dataNascimento = reader.GetDateTime(5);
                            temp.cargo = reader.GetInt32(6);
                            temp.idEmpresa = reader.GetInt32(7);
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

        public bool login(SqlConnection connection)
        {
            bool result = false;
            try
            {
                string comando = "SELECT * FROM Usuario WHERE cht = @cht_PARAM AND senha = @senha_PARAM";
                using (SqlCommand sql = new SqlCommand(comando, connection))
                {
                    SqlParameter chtParam = new SqlParameter("@cht_PARAM", cht);
                    SqlParameter senhaParam = new SqlParameter("@senha_PARAM", senha);

                    sql.Parameters.Add(chtParam);
                    sql.Parameters.Add(senhaParam);

                    using (SqlDataReader leitor = sql.ExecuteReader())
                    {
                        if (leitor.HasRows)
                        {
                            result = true;
                        }
                        return result;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                result = false;
                return result;
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
        public string getCht()
        {
            return cht;
        }
        public void setCht(string cht)
        {
            this.cht = cht;
        }
        public string getPrimeiroNome()
        {
            return primeiroNome;
        }
        public void setPrimeiroNome(string primeiroNome)
        {
            this.primeiroNome = primeiroNome;
        }
        public string getSobrenome()
        {
            return sobrenome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public DateTime getDataNascimento()
        {
            return dataNascimento;
        }
        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }
        public int getCargo()
        {
            return cargo;
        }
        public void setCargo(int cargo)
        {
            this.cargo = cargo;
        }
        public string getSenha()
        {
            return senha;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public int getIdEmpresa()
        {
            return idEmpresa;
        }
        public void setIdEmpresa(int idEmpresa)
        {
            this.idEmpresa = idEmpresa;
        }
    }
}
