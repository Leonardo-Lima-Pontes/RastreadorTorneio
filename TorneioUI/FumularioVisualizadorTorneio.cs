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
                        confrontosSelecionados.Add(confronto);
                    }
                }
            }

            CarregarInformacoesConfronto(confrontosSelecionados.First());
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

            for (int i = 0; i < confronto.TimeCompetindo.Count ; i++)
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
                        if (confronto.TimeCompetindo[0].TimeCompetindo != null)
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
    }
}
