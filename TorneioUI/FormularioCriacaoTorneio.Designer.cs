
namespace TorneioUI
{
    partial class FormularioCriacaoTorneio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCriacaoTorneio));
            this.CabecalhoLabel = new System.Windows.Forms.Label();
            this.NomeTorneioTextBox = new System.Windows.Forms.TextBox();
            this.NomeTorneioLabel = new System.Windows.Forms.Label();
            this.TaxaTorneioTextBox = new System.Windows.Forms.TextBox();
            this.TaxaTorneio = new System.Windows.Forms.Label();
            this.SelecionarTimeLabel = new System.Windows.Forms.Label();
            this.SelecionarTimeComboBox = new System.Windows.Forms.ComboBox();
            this.AdionarTimeButton = new System.Windows.Forms.Button();
            this.AdicionarPremioButton = new System.Windows.Forms.Button();
            this.CriarTorneioButton = new System.Windows.Forms.Button();
            this.TimesJogadoresListBox = new System.Windows.Forms.ListBox();
            this.PremioListBox = new System.Windows.Forms.ListBox();
            this.PremiosLabel = new System.Windows.Forms.Label();
            this.TimesJogadoresLabel = new System.Windows.Forms.Label();
            this.DeletarSelecionadoTimesJogadoresButton = new System.Windows.Forms.Button();
            this.CriarNovoTimeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DeletarPremioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CabecalhoLabel
            // 
            this.CabecalhoLabel.AutoSize = true;
            this.CabecalhoLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CabecalhoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CabecalhoLabel.Location = new System.Drawing.Point(37, 39);
            this.CabecalhoLabel.Name = "CabecalhoLabel";
            this.CabecalhoLabel.Size = new System.Drawing.Size(322, 50);
            this.CabecalhoLabel.TabIndex = 1;
            this.CabecalhoLabel.Text = "Criação do Torneio:";
            // 
            // NomeTorneioTextBox
            // 
            this.NomeTorneioTextBox.Location = new System.Drawing.Point(70, 149);
            this.NomeTorneioTextBox.Name = "NomeTorneioTextBox";
            this.NomeTorneioTextBox.Size = new System.Drawing.Size(272, 35);
            this.NomeTorneioTextBox.TabIndex = 11;
            // 
            // NomeTorneioLabel
            // 
            this.NomeTorneioLabel.AutoSize = true;
            this.NomeTorneioLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeTorneioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.NomeTorneioLabel.Location = new System.Drawing.Point(59, 109);
            this.NomeTorneioLabel.Name = "NomeTorneioLabel";
            this.NomeTorneioLabel.Size = new System.Drawing.Size(230, 37);
            this.NomeTorneioLabel.TabIndex = 10;
            this.NomeTorneioLabel.Text = "Nome do Torneio:";
            // 
            // TaxaTorneioTextBox
            // 
            this.TaxaTorneioTextBox.Location = new System.Drawing.Point(70, 227);
            this.TaxaTorneioTextBox.Name = "TaxaTorneioTextBox";
            this.TaxaTorneioTextBox.Size = new System.Drawing.Size(272, 35);
            this.TaxaTorneioTextBox.TabIndex = 13;
            // 
            // TaxaTorneio
            // 
            this.TaxaTorneio.AutoSize = true;
            this.TaxaTorneio.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaxaTorneio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TaxaTorneio.Location = new System.Drawing.Point(59, 187);
            this.TaxaTorneio.Name = "TaxaTorneio";
            this.TaxaTorneio.Size = new System.Drawing.Size(208, 37);
            this.TaxaTorneio.TabIndex = 12;
            this.TaxaTorneio.Text = "Taxa do Torneio:";
            // 
            // SelecionarTimeLabel
            // 
            this.SelecionarTimeLabel.AutoSize = true;
            this.SelecionarTimeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelecionarTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelecionarTimeLabel.Location = new System.Drawing.Point(59, 265);
            this.SelecionarTimeLabel.Name = "SelecionarTimeLabel";
            this.SelecionarTimeLabel.Size = new System.Drawing.Size(219, 37);
            this.SelecionarTimeLabel.TabIndex = 14;
            this.SelecionarTimeLabel.Text = "Selecione o time:";
            // 
            // SelecionarTimeComboBox
            // 
            this.SelecionarTimeComboBox.FormattingEnabled = true;
            this.SelecionarTimeComboBox.Location = new System.Drawing.Point(70, 305);
            this.SelecionarTimeComboBox.Name = "SelecionarTimeComboBox";
            this.SelecionarTimeComboBox.Size = new System.Drawing.Size(272, 38);
            this.SelecionarTimeComboBox.TabIndex = 15;
            // 
            // AdionarTimeButton
            // 
            this.AdionarTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AdionarTimeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AdionarTimeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AdionarTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdionarTimeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdionarTimeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AdionarTimeButton.Location = new System.Drawing.Point(132, 349);
            this.AdionarTimeButton.Name = "AdionarTimeButton";
            this.AdionarTimeButton.Size = new System.Drawing.Size(146, 42);
            this.AdionarTimeButton.TabIndex = 16;
            this.AdionarTimeButton.Text = "Add Time";
            this.AdionarTimeButton.UseVisualStyleBackColor = true;
            this.AdionarTimeButton.Click += new System.EventHandler(this.AdionarTimeButton_Click);
            // 
            // AdicionarPremioButton
            // 
            this.AdicionarPremioButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AdicionarPremioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AdicionarPremioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AdicionarPremioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarPremioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdicionarPremioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AdicionarPremioButton.Location = new System.Drawing.Point(132, 397);
            this.AdicionarPremioButton.Name = "AdicionarPremioButton";
            this.AdicionarPremioButton.Size = new System.Drawing.Size(146, 42);
            this.AdicionarPremioButton.TabIndex = 17;
            this.AdicionarPremioButton.Text = "Add Premio";
            this.AdicionarPremioButton.UseVisualStyleBackColor = true;
            this.AdicionarPremioButton.Click += new System.EventHandler(this.AdicionarPremioButton_Click);
            // 
            // CriarTorneioButton
            // 
            this.CriarTorneioButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CriarTorneioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CriarTorneioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CriarTorneioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarTorneioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CriarTorneioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CriarTorneioButton.Location = new System.Drawing.Point(258, 506);
            this.CriarTorneioButton.Name = "CriarTorneioButton";
            this.CriarTorneioButton.Size = new System.Drawing.Size(349, 42);
            this.CriarTorneioButton.TabIndex = 18;
            this.CriarTorneioButton.Text = "Criar Torneio";
            this.CriarTorneioButton.UseVisualStyleBackColor = true;
            this.CriarTorneioButton.Click += new System.EventHandler(this.CriarTorneioButton_Click);
            // 
            // TimesJogadoresListBox
            // 
            this.TimesJogadoresListBox.FormattingEnabled = true;
            this.TimesJogadoresListBox.ItemHeight = 30;
            this.TimesJogadoresListBox.Location = new System.Drawing.Point(452, 109);
            this.TimesJogadoresListBox.Name = "TimesJogadoresListBox";
            this.TimesJogadoresListBox.Size = new System.Drawing.Size(264, 154);
            this.TimesJogadoresListBox.TabIndex = 19;
            // 
            // PremioListBox
            // 
            this.PremioListBox.FormattingEnabled = true;
            this.PremioListBox.ItemHeight = 30;
            this.PremioListBox.Location = new System.Drawing.Point(452, 309);
            this.PremioListBox.Name = "PremioListBox";
            this.PremioListBox.Size = new System.Drawing.Size(264, 154);
            this.PremioListBox.TabIndex = 20;
            // 
            // PremiosLabel
            // 
            this.PremiosLabel.AutoSize = true;
            this.PremiosLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PremiosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PremiosLabel.Location = new System.Drawing.Point(452, 269);
            this.PremiosLabel.Name = "PremiosLabel";
            this.PremiosLabel.Size = new System.Drawing.Size(112, 37);
            this.PremiosLabel.TabIndex = 21;
            this.PremiosLabel.Text = "Premios";
            // 
            // TimesJogadoresLabel
            // 
            this.TimesJogadoresLabel.AutoSize = true;
            this.TimesJogadoresLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimesJogadoresLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TimesJogadoresLabel.Location = new System.Drawing.Point(452, 69);
            this.TimesJogadoresLabel.Name = "TimesJogadoresLabel";
            this.TimesJogadoresLabel.Size = new System.Drawing.Size(233, 37);
            this.TimesJogadoresLabel.TabIndex = 22;
            this.TimesJogadoresLabel.Text = "Times / Jogadores";
            // 
            // DeletarSelecionadoTimesJogadoresButton
            // 
            this.DeletarSelecionadoTimesJogadoresButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeletarSelecionadoTimesJogadoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeletarSelecionadoTimesJogadoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeletarSelecionadoTimesJogadoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletarSelecionadoTimesJogadoresButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletarSelecionadoTimesJogadoresButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeletarSelecionadoTimesJogadoresButton.Location = new System.Drawing.Point(735, 149);
            this.DeletarSelecionadoTimesJogadoresButton.Name = "DeletarSelecionadoTimesJogadoresButton";
            this.DeletarSelecionadoTimesJogadoresButton.Size = new System.Drawing.Size(146, 75);
            this.DeletarSelecionadoTimesJogadoresButton.TabIndex = 23;
            this.DeletarSelecionadoTimesJogadoresButton.Text = "Remover Selecionado";
            this.DeletarSelecionadoTimesJogadoresButton.UseVisualStyleBackColor = true;
            this.DeletarSelecionadoTimesJogadoresButton.Click += new System.EventHandler(this.DeletarSelecionadoTimesJogadoresButton_Click);
            // 
            // CriarNovoTimeLinkLabel
            // 
            this.CriarNovoTimeLinkLabel.AutoSize = true;
            this.CriarNovoTimeLinkLabel.Location = new System.Drawing.Point(280, 271);
            this.CriarNovoTimeLinkLabel.Name = "CriarNovoTimeLinkLabel";
            this.CriarNovoTimeLinkLabel.Size = new System.Drawing.Size(163, 30);
            this.CriarNovoTimeLinkLabel.TabIndex = 25;
            this.CriarNovoTimeLinkLabel.TabStop = true;
            this.CriarNovoTimeLinkLabel.Text = "Criar Novo Time";
            this.CriarNovoTimeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CriarNovoTimeLinkLabel_LinkClicked);
            // 
            // DeletarPremioButton
            // 
            this.DeletarPremioButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeletarPremioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeletarPremioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeletarPremioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletarPremioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletarPremioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeletarPremioButton.Location = new System.Drawing.Point(735, 349);
            this.DeletarPremioButton.Name = "DeletarPremioButton";
            this.DeletarPremioButton.Size = new System.Drawing.Size(146, 75);
            this.DeletarPremioButton.TabIndex = 26;
            this.DeletarPremioButton.Text = "Remover Selecionado";
            this.DeletarPremioButton.UseVisualStyleBackColor = true;
            this.DeletarPremioButton.Click += new System.EventHandler(this.DeletarPremioButton_Click);
            // 
            // FormularioCriacaoTorneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 560);
            this.Controls.Add(this.DeletarPremioButton);
            this.Controls.Add(this.CriarNovoTimeLinkLabel);
            this.Controls.Add(this.DeletarSelecionadoTimesJogadoresButton);
            this.Controls.Add(this.TimesJogadoresLabel);
            this.Controls.Add(this.PremiosLabel);
            this.Controls.Add(this.PremioListBox);
            this.Controls.Add(this.TimesJogadoresListBox);
            this.Controls.Add(this.CriarTorneioButton);
            this.Controls.Add(this.AdicionarPremioButton);
            this.Controls.Add(this.AdionarTimeButton);
            this.Controls.Add(this.SelecionarTimeComboBox);
            this.Controls.Add(this.SelecionarTimeLabel);
            this.Controls.Add(this.TaxaTorneioTextBox);
            this.Controls.Add(this.TaxaTorneio);
            this.Controls.Add(this.NomeTorneioTextBox);
            this.Controls.Add(this.NomeTorneioLabel);
            this.Controls.Add(this.CabecalhoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormularioCriacaoTorneio";
            this.Text = "Criação do Torneio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CabecalhoLabel;
        private System.Windows.Forms.TextBox NomeTorneioTextBox;
        private System.Windows.Forms.Label NomeTorneioLabel;
        private System.Windows.Forms.TextBox TaxaTorneioTextBox;
        private System.Windows.Forms.Label TaxaTorneio;
        private System.Windows.Forms.Label SelecionarTimeLabel;
        private System.Windows.Forms.ComboBox SelecionarTimeComboBox;
        private System.Windows.Forms.Button AdionarTimeButton;
        private System.Windows.Forms.Button AdicionarPremioButton;
        private System.Windows.Forms.Button CriarTorneioButton;
        private System.Windows.Forms.ListBox TimesJogadoresListBox;
        private System.Windows.Forms.ListBox PremioListBox;
        private System.Windows.Forms.Label PremiosLabel;
        private System.Windows.Forms.Label TimesJogadoresLabel;
        private System.Windows.Forms.Button DeletarSelecionadoTimesJogadoresButton;
        private System.Windows.Forms.LinkLabel CriarNovoTimeLinkLabel;
        private System.Windows.Forms.Button DeletarPremioButton;
    }
}