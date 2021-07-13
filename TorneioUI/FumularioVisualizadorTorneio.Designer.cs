
namespace TorneioUI
{
    partial class FumularioVisualizadorTorneio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CabecalhoLabel = new System.Windows.Forms.Label();
            this.NomeTorneio = new System.Windows.Forms.Label();
            this.RodadaLabel = new System.Windows.Forms.Label();
            this.RodadaDropdown = new System.Windows.Forms.ComboBox();
            this.NaoJogadoCheckBox = new System.Windows.Forms.CheckBox();
            this.RodadaListBox = new System.Windows.Forms.ListBox();
            this.TimeUmLabel = new System.Windows.Forms.Label();
            this.PontuacaoTimeUmLabel = new System.Windows.Forms.Label();
            this.PontuacaoTimeUmTextBox = new System.Windows.Forms.TextBox();
            this.PontuacaoTimeDoisTextBox = new System.Windows.Forms.TextBox();
            this.PontuacaoTimeDoisLabel = new System.Windows.Forms.Label();
            this.TimeDoisLabel = new System.Windows.Forms.Label();
            this.ContraLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CabecalhoLabel
            // 
            this.CabecalhoLabel.AutoSize = true;
            this.CabecalhoLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CabecalhoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CabecalhoLabel.Location = new System.Drawing.Point(6, 20);
            this.CabecalhoLabel.Name = "CabecalhoLabel";
            this.CabecalhoLabel.Size = new System.Drawing.Size(155, 50);
            this.CabecalhoLabel.TabIndex = 0;
            this.CabecalhoLabel.Text = "Torneiro:";
            // 
            // NomeTorneio
            // 
            this.NomeTorneio.AutoSize = true;
            this.NomeTorneio.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeTorneio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.NomeTorneio.Location = new System.Drawing.Point(167, 20);
            this.NomeTorneio.Name = "NomeTorneio";
            this.NomeTorneio.Size = new System.Drawing.Size(160, 50);
            this.NomeTorneio.TabIndex = 1;
            this.NomeTorneio.Text = "<nome>";
            // 
            // RodadaLabel
            // 
            this.RodadaLabel.AutoSize = true;
            this.RodadaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RodadaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RodadaLabel.Location = new System.Drawing.Point(12, 76);
            this.RodadaLabel.Name = "RodadaLabel";
            this.RodadaLabel.Size = new System.Drawing.Size(108, 37);
            this.RodadaLabel.TabIndex = 2;
            this.RodadaLabel.Text = "Rodada";
            // 
            // RodadaDropdown
            // 
            this.RodadaDropdown.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RodadaDropdown.FormattingEnabled = true;
            this.RodadaDropdown.Location = new System.Drawing.Point(126, 73);
            this.RodadaDropdown.Name = "RodadaDropdown";
            this.RodadaDropdown.Size = new System.Drawing.Size(187, 45);
            this.RodadaDropdown.TabIndex = 3;
            this.RodadaDropdown.SelectedIndexChanged += new System.EventHandler(this.RodadaDropdown_SelectedIndexChanged);
            // 
            // NaoJogadoCheckBox
            // 
            this.NaoJogadoCheckBox.AutoSize = true;
            this.NaoJogadoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NaoJogadoCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NaoJogadoCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.NaoJogadoCheckBox.Location = new System.Drawing.Point(126, 124);
            this.NaoJogadoCheckBox.Name = "NaoJogadoCheckBox";
            this.NaoJogadoCheckBox.Size = new System.Drawing.Size(189, 41);
            this.NaoJogadoCheckBox.TabIndex = 4;
            this.NaoJogadoCheckBox.Text = "Não Jogados";
            this.NaoJogadoCheckBox.UseVisualStyleBackColor = true;
            this.NaoJogadoCheckBox.CheckedChanged += new System.EventHandler(this.NaoJogadoCheckBox_CheckedChanged);
            // 
            // RodadaListBox
            // 
            this.RodadaListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RodadaListBox.FormattingEnabled = true;
            this.RodadaListBox.ItemHeight = 30;
            this.RodadaListBox.Location = new System.Drawing.Point(12, 208);
            this.RodadaListBox.Name = "RodadaListBox";
            this.RodadaListBox.Size = new System.Drawing.Size(301, 242);
            this.RodadaListBox.TabIndex = 5;
            // 
            // TimeUmLabel
            // 
            this.TimeUmLabel.AutoSize = true;
            this.TimeUmLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeUmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TimeUmLabel.Location = new System.Drawing.Point(319, 234);
            this.TimeUmLabel.Name = "TimeUmLabel";
            this.TimeUmLabel.Size = new System.Drawing.Size(151, 37);
            this.TimeUmLabel.TabIndex = 6;
            this.TimeUmLabel.Text = "<time um>";
            // 
            // PontuacaoTimeUmLabel
            // 
            this.PontuacaoTimeUmLabel.AutoSize = true;
            this.PontuacaoTimeUmLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PontuacaoTimeUmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PontuacaoTimeUmLabel.Location = new System.Drawing.Point(319, 271);
            this.PontuacaoTimeUmLabel.Name = "PontuacaoTimeUmLabel";
            this.PontuacaoTimeUmLabel.Size = new System.Drawing.Size(142, 37);
            this.PontuacaoTimeUmLabel.TabIndex = 8;
            this.PontuacaoTimeUmLabel.Text = "Pontuação";
            // 
            // PontuacaoTimeUmTextBox
            // 
            this.PontuacaoTimeUmTextBox.Location = new System.Drawing.Point(467, 273);
            this.PontuacaoTimeUmTextBox.Name = "PontuacaoTimeUmTextBox";
            this.PontuacaoTimeUmTextBox.Size = new System.Drawing.Size(100, 35);
            this.PontuacaoTimeUmTextBox.TabIndex = 9;
            // 
            // PontuacaoTimeDoisTextBox
            // 
            this.PontuacaoTimeDoisTextBox.Location = new System.Drawing.Point(467, 392);
            this.PontuacaoTimeDoisTextBox.Name = "PontuacaoTimeDoisTextBox";
            this.PontuacaoTimeDoisTextBox.Size = new System.Drawing.Size(100, 35);
            this.PontuacaoTimeDoisTextBox.TabIndex = 12;
            // 
            // PontuacaoTimeDoisLabel
            // 
            this.PontuacaoTimeDoisLabel.AutoSize = true;
            this.PontuacaoTimeDoisLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PontuacaoTimeDoisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PontuacaoTimeDoisLabel.Location = new System.Drawing.Point(319, 390);
            this.PontuacaoTimeDoisLabel.Name = "PontuacaoTimeDoisLabel";
            this.PontuacaoTimeDoisLabel.Size = new System.Drawing.Size(142, 37);
            this.PontuacaoTimeDoisLabel.TabIndex = 11;
            this.PontuacaoTimeDoisLabel.Text = "Pontuação";
            // 
            // TimeDoisLabel
            // 
            this.TimeDoisLabel.AutoSize = true;
            this.TimeDoisLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeDoisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TimeDoisLabel.Location = new System.Drawing.Point(319, 353);
            this.TimeDoisLabel.Name = "TimeDoisLabel";
            this.TimeDoisLabel.Size = new System.Drawing.Size(163, 37);
            this.TimeDoisLabel.TabIndex = 10;
            this.TimeDoisLabel.Text = "<time dois>";
            // 
            // ContraLabel
            // 
            this.ContraLabel.AutoSize = true;
            this.ContraLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContraLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ContraLabel.Location = new System.Drawing.Point(406, 316);
            this.ContraLabel.Name = "ContraLabel";
            this.ContraLabel.Size = new System.Drawing.Size(55, 37);
            this.ContraLabel.TabIndex = 13;
            this.ContraLabel.Text = "-X-";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(601, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pontuação";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FumularioVisualizadorTorneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ContraLabel);
            this.Controls.Add(this.PontuacaoTimeDoisTextBox);
            this.Controls.Add(this.PontuacaoTimeDoisLabel);
            this.Controls.Add(this.TimeDoisLabel);
            this.Controls.Add(this.PontuacaoTimeUmTextBox);
            this.Controls.Add(this.PontuacaoTimeUmLabel);
            this.Controls.Add(this.TimeUmLabel);
            this.Controls.Add(this.RodadaListBox);
            this.Controls.Add(this.NaoJogadoCheckBox);
            this.Controls.Add(this.RodadaDropdown);
            this.Controls.Add(this.RodadaLabel);
            this.Controls.Add(this.NomeTorneio);
            this.Controls.Add(this.CabecalhoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FumularioVisualizadorTorneio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torneio Visualizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CabecalhoLabel;
        private System.Windows.Forms.Label NomeTorneio;
        private System.Windows.Forms.Label RodadaLabel;
        private System.Windows.Forms.ComboBox RodadaDropdown;
        private System.Windows.Forms.CheckBox NaoJogadoCheckBox;
        private System.Windows.Forms.ListBox RodadaListBox;
        private System.Windows.Forms.Label TimeUmLabel;
        private System.Windows.Forms.Label PontuacaoTimeUmLabel;
        private System.Windows.Forms.TextBox PontuacaoTimeUmTextBox;
        private System.Windows.Forms.TextBox PontuacaoTimeDoisTextBox;
        private System.Windows.Forms.Label PontuacaoTimeDoisLabel;
        private System.Windows.Forms.Label TimeDoisLabel;
        private System.Windows.Forms.Label ContraLabel;
        private System.Windows.Forms.Button button1;
    }
}

