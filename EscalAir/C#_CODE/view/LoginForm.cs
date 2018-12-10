using PROJETO_INTER.model;
using PROJETO_INTER.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_INTER
{
    public partial class Form1 : Form
    {
        private SqlConnection conexao;
        private Usuario usuario;

        public Form1()
        {
            conexao = ConnectionFactory.getConnection();
            usuario = new Usuario();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {

            usuario.setCht(loginTextBox.Text);
            usuario.setSenha(senhaTextBox.Text);

            if (usuario.login(this.conexao))
            {
                Program.usuario = usuario.carregarUsuario(conexao, usuario.getCht());
                Form2 frm = new Form2();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!");
                limparCampos();
            }
        }

        private void limparCampos()
        {
            loginTextBox.Clear();
            senhaTextBox.Clear();
            loginTextBox.Focus();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            LoginAdmin adminForm = new LoginAdmin();
            adminForm.Show();
        }
    }
}
