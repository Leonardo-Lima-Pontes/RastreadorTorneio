using RastreadorBiblioteca;
using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneioUI
{
    public partial class FumularioVisualizadorTorneio : Form
    {
        private TorneioModelo torneio;
        BindingList<int> rodadas = new BindingList<int>();
        BindingList<ConfrontoModelo> confrontosSelecionados = new BindingList<ConfrontoModelo>();

        public FumularioVisualizadorTorneio(TorneioModelo torneioModelo)
        {
            InitializeComponent();

            torneio = torneioModelo;

            CarregarListas();

            CarregarNomeTorneio();

            CarregarRodadas();
        }

        private void CarregarNomeTorneio()
        {
            NomeTorneio.Text = torneio.TorneioNome;
        }

        private void CarregarListas()
        {
            RodadaDropdown.DataSource = rodadas;
            RodadaListBox.DataSource = confrontosSelecionados;
            RodadaListBox.DisplayMember = "NomeTimesConfronto";
        }

        private void CarregarRodadas()
        {
            rodadas.Clear();

            rodadas.Add(1);
            int rodadaAtual = 1;

            foreach (List<ConfrontoModelo> confrontos in torneio.Rodadas)
            {
                if (confrontos.First().RodadaConfronto > rodadaAtual)
                {
                    rodadaAtual = confrontos.First().RodadaConfronto;
                    rodadas.Add(rodadaAtual);
                }
            }

            CarregarConfrontos(1);

        }

        private void RodadaDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarConfrontos((int)RodadaDropdown.SelectedItem);
        }

        /// <summary>
        /// Carrega os confrontos na lista de confrontos
        /// </summary>
        private void CarregarConfrontos(int rodada)
        {
            foreach (List<ConfrontoModelo> confrontos in torneio.Rodadas)
            {
                if (confrontos.First().RodadaConfronto == rodada)
                {
                    confrontosSelecionados.Clear();
                    foreach (ConfrontoModelo confronto in confrontos)
                    {
                        if (confronto.Vencedor == null || !NaoJogadoCheckBox.Checked)
                        {
                            confrontosSelecionados.Add(confronto);
                        }
                    }
                }
            }

            if (confrontosSelecionados.Count > 0)
            {
                CarregarInformacoesConfronto(confrontosSelecionados.First()); 
            }

            MostrarConfrontoInfo();
        }

        private void MostrarConfrontoInfo()
        {
            bool estaVisivel = (confrontosSelecionados.Count > 0);

            TimeUmLabel.Visible = estaVisivel;
            PontuacaoTimeUmLabel.Visible = estaVisivel;
            PontuacaoTimeUmTextBox.Visible = estaVisivel;
            TimeDoisLabel.Visible = estaVisivel;
            PontuacaoTimeDoisLabel.Visible = estaVisivel;
            PontuacaoTimeDoisTextBox.Visible = estaVisivel;
            ContraLabel.Visible = estaVisivel;
            PontuacaoButton.Visible = estaVisivel;
        }

        private void RodadaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarInformacoesConfronto((ConfrontoModelo)RodadaListBox.SelectedItem);
        }

        private void CarregarInformacoesConfronto(ConfrontoModelo confronto)
        {
            if (confronto == null)
            {
                return;
            }

            for (int i = 0; i < confronto.TimeCompetindo.Count; i++)
            {
                if (i == 0)
                {
                    if (confronto.TimeCompetindo[0] != null)
                    {
                        if (confronto.TimeCompetindo[0].TimeCompetindo != null)
                        {
                            TimeUmLabel.Text = confronto.TimeCompetindo[0].TimeCompetindo.NomeTime;
                            PontuacaoTimeUmTextBox.Text = confronto.TimeCompetindo[0].Pontuacao.ToString();
                        }
                        else
                        {
                            TimeUmLabel.Text = "Ainda não se sabe";
                            PontuacaoTimeUmTextBox.Text = "";

                        }

                        TimeDoisLabel.Text = "Ainda não se sabe";
                        PontuacaoTimeDoisTextBox.Text = "";
                    }
                    else
                    {
                        TimeUmLabel.Text = "Ainda não se sabe";
                        PontuacaoTimeUmTextBox.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (confronto.TimeCompetindo[1] != null)
                    {
                        if (confronto.TimeCompetindo[1].TimeCompetindo != null)
                        {
                            TimeDoisLabel.Text = confronto.TimeCompetindo[1].TimeCompetindo.NomeTime;
                            PontuacaoTimeDoisTextBox.Text = confronto.TimeCompetindo[1].Pontuacao.ToString();
                        }
                        else
                        {
                            TimeDoisLabel.Text = "Ainda não se sabe";
                            PontuacaoTimeDoisTextBox.Text = "";
                        }
                    }
                    else
                    {
                        TimeDoisLabel.Text = "Ainda não se sabe";
                        PontuacaoTimeDoisTextBox.Text = "";
                    }
                }

            }
        }

        private void NaoJogadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CarregarConfrontos((int)RodadaDropdown.SelectedItem);
        }

        private string ValidarFormulario()
        {
            string erroValidacao = "";

            double pontuacaoTimeUm = 0;
            double pontuacaoTimeDois = 0;

            bool validaPontuacaoTimeUm = double.TryParse(this.PontuacaoTimeUmTextBox.Text, out pontuacaoTimeUm);
            bool validaPontuacaoTimeDois = double.TryParse(this.PontuacaoTimeUmTextBox.Text, out pontuacaoTimeDois);

            if (!validaPontuacaoTimeUm || !validaPontuacaoTimeDois)
            {
                erroValidacao = "Apenas digite valores numero para informar a pontuação dos times!";
            }
            else if (pontuacaoTimeUm == 0  && pontuacaoTimeDois == 0)
            {
                erroValidacao = "0 x 0 não é permitido no torneio";
            }
            else if (pontuacaoTimeDois == pontuacaoTimeUm)
            {
                erroValidacao = "Empates não são permitidos neste torneio !";
            }

            return erroValidacao;
        }

        private void PontuacaoButton_Click(object sender, EventArgs e)
        {
            string formularioValidado = ValidarFormulario();
            if (formularioValidado.Length > 0)
            {
                MessageBox.Show(formularioValidado);
                return;
            }

            ConfrontoModelo confronto = (ConfrontoModelo)RodadaListBox.SelectedItem;
            double pontuacaoTimeUm = 0;
            double pontuacaoTimeDois = 0;

            for (int i = 0; i < confronto.TimeCompetindo.Count; i++)
            {
                if (i == 0)
                {
                    if (confronto.TimeCompetindo[0] != null)
                    {
                        bool validarPontuacao = double.TryParse(PontuacaoTimeUmTextBox.Text, out pontuacaoTimeUm);

                        if (validarPontuacao)
                        {
                            confronto.TimeCompetindo[0].Pontuacao = pontuacaoTimeUm;
                        }
                        else
                        {
                            MessageBox.Show("Por favor informe um valor valido para a pontuação do time 1");
                        }
                    }
                }
                if (i == 1)
                {
                    if (confronto.TimeCompetindo[1] != null)
                    {
                        bool validarPontuacao = double.TryParse(PontuacaoTimeDoisTextBox.Text, out pontuacaoTimeDois);

                        if (validarPontuacao)
                        {
                            confronto.TimeCompetindo[1].Pontuacao = pontuacaoTimeDois;
                        }
                        else
                        {
                            MessageBox.Show("Por favor informe um valor valido para a pontuação do time 2");
                        }
                    }
                }
            }


            try
            {
                TorneioLogica.AtualizarReusultadosTorneio(torneio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("O seguinte erro ocorreu:", ex.Message);
            }

           CarregarConfrontos((int)RodadaDropdown.SelectedItem);
        }
    }
}
