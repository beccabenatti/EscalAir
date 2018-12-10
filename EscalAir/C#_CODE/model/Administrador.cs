using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_INTER.model
{
    class Administrador
    {
        private int id;
        private string login;
        private string senha;

        public bool loginAdmin(SqlConnection connection)
        {
            bool result = false;
            try
            {
                string comando = "SELECT * FROM Administrador WHERE nome = @login_PARAM AND senha = @senha_PARAM";
                using (SqlCommand sql = new SqlCommand(comando, connection))
                {
                    SqlParameter loginParam = new SqlParameter("@login_PARAM", login);
                    SqlParameter senhaParam = new SqlParameter("@senha_PARAM", senha);

                    sql.Parameters.Add(loginParam);
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

        public string getLogin()
        {
            return login;
        }
        public void setLogin(string login)
        {
            this.login = login;
        }

        public string getSenha()
        {
            return senha;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }
    }
}
