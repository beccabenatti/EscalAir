using PROJETO_INTER.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_INTER
{
    public partial class Form3 : Form
    {
        private int idVoo;
        public Form3(int idVoo)
        {
            InitializeComponent();
            this.idVoo = idVoo;
            carregarInfo();
            preencherForm();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carregarInfo()
        {
        }

        private void preencherForm()
        {
            InfoVoo infoVooDAO = new InfoVoo();
            InfoVoo infoVoo = infoVooDAO.CarregarVoo(ConnectionFactory.getConnection(), this.idVoo);
            aviaoLabel.Text = infoVoo.getAviao();
            partidaLabel.Text = infoVoo.getOrigem();
            horaPartidaLabel.Text = infoVoo.getHoraDePartida().ToString("dd/MM/yyyy @ hh:mm tt", CultureInfo.InvariantCulture);
            chegadaLabel.Text = infoVoo.getDestino();
            horaChegadaLabel.Text = infoVoo.getHoraDeChegada().ToString("dd/MM/yyyy @ hh:mm tt", CultureInfo.InvariantCulture);
            pilotoLabel.Text = infoVoo.getPiloto();
            copilotoLabel.Text = infoVoo.getCopiloto();
            comissarioChefeLabel.Text = infoVoo.getComissarioChefe();
            comissarioUmLabel.Text = infoVoo.getComissarioUm();
            comissarioDoisLabel.Text = infoVoo.getComissarioDois();
        }
    }
}
