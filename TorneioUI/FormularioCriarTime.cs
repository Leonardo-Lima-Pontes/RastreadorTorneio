using RastreadorBiblioteca;
using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TorneioUI
{
    public partial class FormularioCriarTime : Form
    {

        private List<PessoaModelo> pessoasDisponiveis = ConfiguracaoGlobal.Conexao.SelecionarTodasPessoas();
        private List<PessoaModelo> pessoasSelecionadas = new List<PessoaModelo>();
        private ITimeSolicitante formularioSolicitante;

        public FormularioCriarTime(ITimeSolicitante solicitante)
        {
            InitializeComponent();
            preencherListas();

            formularioSolicitante = solicitante;
        }

        private void preencherListas()
        {
            SelecionarJogadorComboBox.DataSource = null;
            SelecionarJogadorComboBox.DataSource = pessoasDisponiveis;
            SelecionarJogadorComboBox.DisplayMember = "NomeCompleto";

            ListaDeJogadoresListBox.DataSource = null;
            ListaDeJogadoresListBox.DataSource = pessoasSelecionadas;
            ListaDeJogadoresListBox.DisplayMember = "NomeCompleto";
        }

        private void AdionarTimeButton_Click(object sender, EventArgs e)
        {
            PessoaModelo pessoa = (PessoaModelo)SelecionarJogadorComboBox.SelectedItem;

            if (pessoa != null)
            {
                pessoasDisponiveis.Remove(pessoa);
                pessoasSelecionadas.Add(pessoa);

                preencherListas();
            }
        }

        private void CriarJogadorButton_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                PessoaModelo pessoa = new PessoaModelo();
                pessoa.PrimeiroNome = PrimeiroNomeTextBox.Text;
                pessoa.UltimoNome = UltimoNomeTextBox.Text;
                pessoa.Telefone = TelefoneTextBox.Text;
                pessoa.Email = EmailTextBox.Text;
                pessoa.DataCriacao = DateTime.Now;

                ConfiguracaoGlobal.Conexao.CriaPessoa(pessoa);
                pessoasSelecionadas.Add(pessoa);

                preencherListas();

                PrimeiroNomeTextBox.Text = "";
                UltimoNomeTextBox.Text = "";
                TelefoneTextBox.Text = "";
                EmailTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Preencha todos os campos !");
            }

        }

        private bool ValidarFormulario()
        {

            if (this.PrimeiroNomeTextBox.Text.Length == 0)
            {
                return false;
            }

            if (this.UltimoNomeTextBox.Text.Length == 0)
            {
                return false;
            }

            if (this.TelefoneTextBox.Text.Length == 0)
            {
                return false;
            }

            if (this.EmailTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void RemoverJogadorSelecionadoButton_Click(object sender, EventArgs e)
        {
            PessoaModelo pessoa = (PessoaModelo)ListaDeJogadoresListBox.SelectedItem;
            if (pessoa != null)
            {
                pessoasDisponiveis.Add(pessoa);
                pessoasSelecionadas.Remove(pessoa);

                preencherListas();
            }
        }

        private void CriarTimeButton_Click(object sender, EventArgs e)
        {
            TimeModelo time = new TimeModelo();

            time.NomeTime = NomeTimeTextBox.Text;
            time.MembrosTime = pessoasSelecionadas;

            ConfiguracaoGlobal.Conexao.CriaTime(time);

            formularioSolicitante.TimeCompleto(time);
            this.Close();

            // TODO - se nós não fecharmos este formulario apos gravar precisaremos resetalo
        }
    }
}
