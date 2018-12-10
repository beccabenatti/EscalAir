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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            Cargo cargos = new Cargo();
            foreach (Cargo c in cargos.carregarCargos(ConnectionFactory.getConnection()))
            {
                cargoComboBox.Items.Add(c.getDescricao());
            }
            Empresa empresas = new Empresa();
            foreach (Empresa e in empresas.carregarEmpresas(ConnectionFactory.getConnection()))
            {
                empresaComboBox.Items.Add(e.getNomeEmpresa());
            }
            Aviao avioes = new Aviao();
            foreach (Aviao a in avioes.carregarAvioes(ConnectionFactory.getConnection()))
            {
                aviaoComboBox.Items.Add(a.getTipo());
            }
            Usuario usuarios = new Usuario();
            foreach(Usuario u in usuarios.carregarUsuarios(ConnectionFactory.getConnection()))
            {
                pilotoComboBox.Items.Add(u.getPrimeiroNome() + " " + u.getSobrenome());
                copilotoComboBox.Items.Add(u.getPrimeiroNome() + " " + u.getSobrenome());
                comChefeComboBox.Items.Add(u.getPrimeiroNome() + " " + u.getSobrenome());
                comUmComboBox.Items.Add(u.getPrimeiroNome() + " " + u.getSobrenome());
                comDoisComboBox.Items.Add(u.getPrimeiroNome() + " " + u.getSobrenome());
            }
        }

        private void cadastrarUsuarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.setCht(chtTextBox.Text);
                usuario.setCargo(cargoComboBox.SelectedIndex + 1);
                usuario.setCpf(cpfTextBox.Text);
                usuario.setDataNascimento(dataNascDateTimePicker.Value);
                usuario.setIdEmpresa(empresaComboBox.SelectedIndex + 1);
                usuario.setPrimeiroNome(nomeTextBox.Text);
                usuario.setSobrenome(sobrenomeTextBox.Text);
                usuario.setSenha(senhaTextBox.Text);
                usuario.inserirUsuario(ConnectionFactory.getConnection());
                Endereco endereco = new Endereco();
                endereco.setBairro(bairroTextBox.Text);
                endereco.setCidade(cidadeTextBox.Text);
                endereco.setEstado(estadoTextBox.Text);
                endereco.setIdUsuario(usuario.getLastIdUsuario(ConnectionFactory.getConnection()));
                endereco.setNumero(int.Parse(numeroTextBox.Text));
                endereco.setRua(ruaTextBox.Text);
                endereco.inserirEndereco(ConnectionFactory.getConnection());
                Telefone telefone = new Telefone();
                telefone.setIdUsuario(usuario.getLastIdUsuario(ConnectionFactory.getConnection()));
                telefone.setTelefone(telefoneTextBox.Text);
                telefone.inserirTelefone(ConnectionFactory.getConnection());
                MessageBox.Show("Cadastrado!");
                foreach (Control c in tabPage1.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    } else if (c is ComboBox)
                    {
                        ((ComboBox)c).Items.Clear();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void cadastrarEmpresaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empresa = new Empresa();
                empresa.setNomeEmpresa(empresaTextBox.Text);
                empresa.inserirEmpresa(ConnectionFactory.getConnection());
                MessageBox.Show("Cadastrado!");
                foreach (Control c in tabPage2.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    else if (c is ComboBox)
                    {
                        ((ComboBox)c).Items.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void cadastrarAviaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Aviao aviao = new Aviao();
                aviao.setTipo(aviaoTextBox.Text);
                aviao.inserirAviao(ConnectionFactory.getConnection());
                MessageBox.Show("Cadastrado!");
                foreach (Control c in tabPage3.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    else if (c is ComboBox)
                    {
                        ((ComboBox)c).Items.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void cadastrarCargoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cargo cargo = new Cargo();
                cargo.setDescricao(cargoTextBox.Text);
                cargo.inserirCargo(ConnectionFactory.getConnection());
                MessageBox.Show("Cadastrado!");
                foreach (Control c in tabPage4.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    else if (c is ComboBox)
                    {
                        ((ComboBox)c).Items.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void cadastrarVooButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tripulacao tripulacao = new Tripulacao();
                tripulacao.setIdComissarioChefe(comChefeComboBox.SelectedIndex + 1);
                tripulacao.setIdComissarioDois(comDoisComboBox.SelectedIndex + 1);
                tripulacao.setIdComissarioUm(comUmComboBox.SelectedIndex + 1);
                tripulacao.setIdCopiloto(copilotoComboBox.SelectedIndex + 1);
                tripulacao.setIdPiloto(pilotoComboBox.SelectedIndex + 1);
                tripulacao.inserirTripulacao(ConnectionFactory.getConnection());
                Voo voo = new Voo();
                voo.setAviaoId(aviaoComboBox.SelectedIndex + 1);
                voo.setDestino(destinoTextBox.Text);
                voo.setHoraChegada(chegadaDateTimePicker.Value);
                voo.setHoraPartida(partidaDateTimePicker.Value);
                voo.setNumeroPassageiros(Convert.ToInt32(qntPassagTextBox.Text));
                voo.setOrigem(origemTextBox.Text);
                voo.setTripulacaoId(tripulacao.getLastIdTripulacao(ConnectionFactory.getConnection()));
                voo.inserirVoo(ConnectionFactory.getConnection());
                MessageBox.Show("Cadastrado!");
                foreach (Control c in tabPage5.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    else if (c is ComboBox)
                    {
                        ((ComboBox)c).Items.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
