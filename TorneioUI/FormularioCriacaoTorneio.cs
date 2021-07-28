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
    public partial class FormularioCriacaoTorneio : Form, IPremioSolicitante, ITimeSolicitante
    {
        private List<TimeModelo> timesDisponiveis = ConfiguracaoGlobal.Conexao.SelecionarTodosTimes();
        private List<TimeModelo> timesSelecionados = new List<TimeModelo>();
        private List<PremioModelo> premiosSelecionados = new List<PremioModelo>();

        public FormularioCriacaoTorneio()
        {
            InitializeComponent();
            CarregarListas();
        }

        private void CarregarListas()
        {
            this.SelecionarTimeComboBox.DataSource = null;
            this.SelecionarTimeComboBox.DataSource = timesDisponiveis;
            this.SelecionarTimeComboBox.DisplayMember = "NomeTime";

            this.TimesJogadoresListBox.DataSource = null;
            this.TimesJogadoresListBox.DataSource = timesSelecionados;
            this.TimesJogadoresListBox.DisplayMember = "NomeTime";

            this.PremioListBox.DataSource = null;
            this.PremioListBox.DataSource = premiosSelecionados;
            this.PremioListBox.DisplayMember = "ColocacaoNome";
        }

        private void AdionarTimeButton_Click(object sender, EventArgs e)
        {
            TimeModelo time = (TimeModelo)SelecionarTimeComboBox.SelectedItem;

            if (time != null)
            {
                timesDisponiveis.Remove(time);
                timesSelecionados.Add(time);

                CarregarListas();
            }
        }

        private void DeletarSelecionadoTimesJogadoresButton_Click(object sender, EventArgs e)
        {
            TimeModelo time = (TimeModelo)TimesJogadoresListBox.SelectedItem;

            if (time != null)
            {
                timesSelecionados.Remove(time);
                timesDisponiveis.Add(time);

                CarregarListas();
            }
        }

        public void PremioCompleto(PremioModelo premio)
        {
            premiosSelecionados.Add(premio);
            CarregarListas();
        }

        private void AdicionarPremioButton_Click(object sender, EventArgs e)
        {
            FormularioCriarPremio formularioPremio = new FormularioCriarPremio(this);
            formularioPremio.Show();
        }

        public void TimeCompleto(TimeModelo time)
        {
            this.timesSelecionados.Add(time);
            CarregarListas();
        }

        private void CriarNovoTimeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioCriarTime time = new FormularioCriarTime(this);
            time.Show();
        }

        private void DeletarPremioButton_Click(object sender, EventArgs e)
        {
            PremioModelo premio = (PremioModelo)PremioListBox.SelectedItem;

            if (premio != null)
            {
                premiosSelecionados.Remove(premio);

                CarregarListas();
            }
        }

        private void CriarTorneioButton_Click(object sender, EventArgs e)
        {
            TorneioModelo torneio = new TorneioModelo();

            decimal taxaTorneio;
            bool validaTaxa = decimal.TryParse(this.TaxaTorneioTextBox.Text, out taxaTorneio);

            if (!validaTaxa)
            {
                MessageBox.Show("Você precisa informar qual é taxa do torneio", "TAXA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            torneio.TaxaEntrada = taxaTorneio;
            torneio.TorneioNome = this.NomeTorneioTextBox.Text;
            torneio.Premios = premiosSelecionados;
            torneio.TimesIncritos = timesSelecionados;

            TorneioLogica.CriarRodadas(torneio);

            ConfiguracaoGlobal.Conexao.CriaTorneio(torneio);

            FumularioVisualizadorTorneio formularioVisualizadorTorneio = new FumularioVisualizadorTorneio(torneio);
            formularioVisualizadorTorneio.Show();
            this.Close();
        }
    }
}
