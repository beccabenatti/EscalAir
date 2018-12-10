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

namespace PROJETO_INTER
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            Empresa e = new Empresa();
            e = e.carregarEmpresa(ConnectionFactory.getConnection(), Program.usuario.getIdEmpresa());
            InitializeComponent();
            nomeLabel.Text = Program.usuario.getPrimeiroNome() + " " + Program.usuario.getSobrenome();
            dataNascLabel.Text = Program.usuario.getDataNascimento().ToString("dd/MM/yyyy");
            empresaLabel.Text = e.getNomeEmpresa();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regulamentacaoButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.anac.gov.br/participacao-social/audiencias-e-consultas-publicas/audiencias/2015/aud17/anexorbac91.pdf");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //textBox1.Text = e.Start.Date.ToString("dd/MM/yyyy");

            Form3 frm3 = new Form3(int.Parse(voosComboBox.Text));
            frm3.ShowDialog();
        }

        private void carregarVoosButton_Click(object sender, EventArgs e)
        {
            Voo voo = new Voo();
            List<Voo> voos = voo.carregarVoosPorData(ConnectionFactory.getConnection(), monthCalendar1.SelectionEnd);
            voosComboBox.Items.Clear();
            foreach(Voo v in voos)
            {
                voosComboBox.Items.Add(v.getId());
            }
        }
    }
}
// FOCAR NO ADMINISTRADOR- ELE PODERÁ ADICIONAR USUÁRIO, ALTERAR DADOS, EXCLUIR E INSERIR DADOS