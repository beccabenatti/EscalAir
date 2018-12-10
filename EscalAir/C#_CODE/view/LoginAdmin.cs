using PROJETO_INTER.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_INTER.view
{
    public partial class LoginAdmin : Form
    {
        private Administrador admin;
        public LoginAdmin()
        {
            admin = new Administrador();
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            admin.setLogin(loginTextBox.Text);
            admin.setSenha(senhaTextBox.Text);

            if (admin.loginAdmin(ConnectionFactory.getConnection())) 
            {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas"); 
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }
            }
        }
    }
}
