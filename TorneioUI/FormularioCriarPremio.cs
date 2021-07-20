using RastreadorBiblioteca;
using RastreadorBiblioteca.AcessoDeDados;
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
    public partial class FormularioCriarPremio : Form
    {
        private IPremioSolicitante formularioSolicitante;

        public FormularioCriarPremio(IPremioSolicitante solicitante)
        {
            InitializeComponent();

            formularioSolicitante = solicitante;
        }

        private void CriarPremioButton_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                PremioModelo premio = new PremioModelo(
                    NumeroColocacaoTextBox.Text,
                    NomeColocacaoTextBox.Text,
                    MontantePremioTextBox.Text,
                    PorcentagemPremioTextBox.Text);

                ConfiguracaoGlobal.Conexao.CriaPremio(premio);

                formularioSolicitante.PremioCompleto(premio);

                this.Close();
            }
            else
            {
                MessageBox.Show("O formulário contem informações invalidas, por gentileza redija as informações e tente novamente");
            }
        }

        private bool ValidarFormulario()
        {
            // valida o formulario PremioModelo

            bool saida = true;

            int numeroColocacao = 0;
            bool numeroColocacaoValidar = int.TryParse(NumeroColocacaoTextBox.Text, out numeroColocacao);
            if (numeroColocacaoValidar == false)
            {
                saida = false;
            }

            if (numeroColocacao < 0)
            {
                saida = false;
            }

            if (NomeColocacaoTextBox.Text.Length == 0)
            {
                saida = false;
            }

            decimal premioValor = 0;
            double premioPorcentagem = 0;

            bool premioValorValidar = decimal.TryParse(MontantePremioTextBox.Text, out premioValor);
            bool premioPorcentagemValidar = double.TryParse(PorcentagemPremioTextBox.Text, out premioPorcentagem);

            if (premioValorValidar == false || premioPorcentagemValidar == false)
            {
                saida = false;
            }

            if (premioValor == 0 && premioPorcentagem == 0)
            {
                saida = false;
            }

            if (premioPorcentagem < 0 || premioPorcentagem > 100)
            {
                saida = false;
            }

            return saida;
        }
    }
}
