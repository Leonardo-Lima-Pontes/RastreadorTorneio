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
        public FormularioCriarTime()
        {
            InitializeComponent();
        }

        private void AdionarTimeButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
