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
    public partial class FormularioInicial : Form
    {
        List<TorneioModelo> torneios = ConfiguracaoGlobal.Conexao.SelecionarTodosTorneios();

        public FormularioInicial()
        {
            InitializeComponent();
            ConstruirLista();
        }

        private void ConstruirLista()
        {
            CarregarTorneioComboBox.DataSource = torneios;
            CarregarTorneioComboBox.DisplayMember = "TorneioNome";
        }

        private void CriarTorneioButton_Click(object sender, EventArgs e)
        {
            FormularioCriacaoTorneio formularioCriarTorneio = new FormularioCriacaoTorneio();
            formularioCriarTorneio.Show();
        }
    }
}
