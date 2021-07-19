
namespace TorneioUI
{
    partial class FormularioCriarTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCriarTime));
            this.AdicionarJogadorButton = new System.Windows.Forms.Button();
            this.NomeTimeTextBox = new System.Windows.Forms.TextBox();
            this.NomeTimeLabel = new System.Windows.Forms.Label();
            this.CabecalhoLabel = new System.Windows.Forms.Label();
            this.SelecionarJogadorLabel = new System.Windows.Forms.Label();
            this.JogadorInformacoesGroupBox = new System.Windows.Forms.GroupBox();
            this.TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.UltimoNomeTextBox = new System.Windows.Forms.TextBox();
            this.PrimeiroNomeTextBox = new System.Windows.Forms.TextBox();
            this.TelefoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UltimoNomeLabel = new System.Windows.Forms.Label();
            this.PrimeiroNomeLabel = new System.Windows.Forms.Label();
            this.CriarJogadorButton = new System.Windows.Forms.Button();
            this.ListaDeJogadoresListBox = new System.Windows.Forms.ListBox();
            this.RemoverJogadorSelecionadoButton = new System.Windows.Forms.Button();
            this.CriarTimeButton = new System.Windows.Forms.Button();
            this.SelecionarJogadorComboBox = new System.Windows.Forms.ComboBox();
            this.JogadorInformacoesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdicionarJogadorButton
            // 
            this.AdicionarJogadorButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AdicionarJogadorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AdicionarJogadorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AdicionarJogadorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarJogadorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdicionarJogadorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AdicionarJogadorButton.Location = new System.Drawing.Point(90, 242);
            this.AdicionarJogadorButton.Name = "AdicionarJogadorButton";
            this.AdicionarJogadorButton.Size = new System.Drawing.Size(146, 72);
            this.AdicionarJogadorButton.TabIndex = 20;
            this.AdicionarJogadorButton.Text = "Adicionar Jogador";
            this.AdicionarJogadorButton.UseVisualStyleBackColor = true;
            this.AdicionarJogadorButton.Click += new System.EventHandler(this.AdionarTimeButton_Click);
            // 
            // NomeTimeTextBox
            // 
            this.NomeTimeTextBox.Location = new System.Drawing.Point(30, 120);
            this.NomeTimeTextBox.Name = "NomeTimeTextBox";
            this.NomeTimeTextBox.Size = new System.Drawing.Size(272, 35);
            this.NomeTimeTextBox.TabIndex = 19;
            // 
            // NomeTimeLabel
            // 
            this.NomeTimeLabel.AutoSize = true;
            this.NomeTimeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.NomeTimeLabel.Location = new System.Drawing.Point(21, 80);
            this.NomeTimeLabel.Name = "NomeTimeLabel";
            this.NomeTimeLabel.Size = new System.Drawing.Size(195, 37);
            this.NomeTimeLabel.TabIndex = 18;
            this.NomeTimeLabel.Text = "Nome do time:";
            // 
            // CabecalhoLabel
            // 
            this.CabecalhoLabel.AutoSize = true;
            this.CabecalhoLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CabecalhoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CabecalhoLabel.Location = new System.Drawing.Point(244, 9);
            this.CabecalhoLabel.Name = "CabecalhoLabel";
            this.CabecalhoLabel.Size = new System.Drawing.Size(284, 50);
            this.CabecalhoLabel.TabIndex = 17;
            this.CabecalhoLabel.Text = "Criação do Time:";
            // 
            // SelecionarJogadorLabel
            // 
            this.SelecionarJogadorLabel.AutoSize = true;
            this.SelecionarJogadorLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelecionarJogadorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelecionarJogadorLabel.Location = new System.Drawing.Point(21, 161);
            this.SelecionarJogadorLabel.Name = "SelecionarJogadorLabel";
            this.SelecionarJogadorLabel.Size = new System.Drawing.Size(246, 37);
            this.SelecionarJogadorLabel.TabIndex = 21;
            this.SelecionarJogadorLabel.Text = "Selecionar jogador:";
            this.SelecionarJogadorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // JogadorInformacoesGroupBox
            // 
            this.JogadorInformacoesGroupBox.Controls.Add(this.TelefoneTextBox);
            this.JogadorInformacoesGroupBox.Controls.Add(this.EmailTextBox);
            this.JogadorInformacoesGroupBox.Controls.Add(this.UltimoNomeTextBox);
            this.JogadorInformacoesGroupBox.Controls.Add(this.PrimeiroNomeTextBox);
            this.JogadorInformacoesGroupBox.Controls.Add(this.TelefoneLabel);
            this.JogadorInformacoesGroupBox.Controls.Add(this.EmailLabel);
            this.JogadorInformacoesGroupBox.Controls.Add(this.UltimoNomeLabel);
            this.JogadorInformacoesGroupBox.Controls.Add(this.PrimeiroNomeLabel);
            this.JogadorInformacoesGroupBox.Controls.Add(this.CriarJogadorButton);
            this.JogadorInformacoesGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JogadorInformacoesGroupBox.Location = new System.Drawing.Point(30, 348);
            this.JogadorInformacoesGroupBox.Name = "JogadorInformacoesGroupBox";
            this.JogadorInformacoesGroupBox.Size = new System.Drawing.Size(272, 256);
            this.JogadorInformacoesGroupBox.TabIndex = 23;
            this.JogadorInformacoesGroupBox.TabStop = false;
            this.JogadorInformacoesGroupBox.Text = "Cadastro de Jogador";
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.Location = new System.Drawing.Point(123, 157);
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Size = new System.Drawing.Size(138, 29);
            this.TelefoneTextBox.TabIndex = 35;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(123, 120);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(138, 29);
            this.EmailTextBox.TabIndex = 34;
            // 
            // UltimoNomeTextBox
            // 
            this.UltimoNomeTextBox.Location = new System.Drawing.Point(123, 83);
            this.UltimoNomeTextBox.Name = "UltimoNomeTextBox";
            this.UltimoNomeTextBox.Size = new System.Drawing.Size(138, 29);
            this.UltimoNomeTextBox.TabIndex = 33;
            // 
            // PrimeiroNomeTextBox
            // 
            this.PrimeiroNomeTextBox.Location = new System.Drawing.Point(123, 46);
            this.PrimeiroNomeTextBox.Name = "PrimeiroNomeTextBox";
            this.PrimeiroNomeTextBox.Size = new System.Drawing.Size(138, 29);
            this.PrimeiroNomeTextBox.TabIndex = 29;
            // 
            // TelefoneLabel
            // 
            this.TelefoneLabel.AutoSize = true;
            this.TelefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelefoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TelefoneLabel.Location = new System.Drawing.Point(6, 161);
            this.TelefoneLabel.Name = "TelefoneLabel";
            this.TelefoneLabel.Size = new System.Drawing.Size(75, 20);
            this.TelefoneLabel.TabIndex = 32;
            this.TelefoneLabel.Text = "Telefone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(6, 124);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(52, 20);
            this.EmailLabel.TabIndex = 31;
            this.EmailLabel.Text = "Email:";
            // 
            // UltimoNomeLabel
            // 
            this.UltimoNomeLabel.AutoSize = true;
            this.UltimoNomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UltimoNomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UltimoNomeLabel.Location = new System.Drawing.Point(6, 87);
            this.UltimoNomeLabel.Name = "UltimoNomeLabel";
            this.UltimoNomeLabel.Size = new System.Drawing.Size(102, 20);
            this.UltimoNomeLabel.TabIndex = 30;
            this.UltimoNomeLabel.Text = "Ultimo nome:";
            // 
            // PrimeiroNomeLabel
            // 
            this.PrimeiroNomeLabel.AutoSize = true;
            this.PrimeiroNomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrimeiroNomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrimeiroNomeLabel.Location = new System.Drawing.Point(6, 50);
            this.PrimeiroNomeLabel.Name = "PrimeiroNomeLabel";
            this.PrimeiroNomeLabel.Size = new System.Drawing.Size(114, 20);
            this.PrimeiroNomeLabel.TabIndex = 29;
            this.PrimeiroNomeLabel.Text = "Primeiro nome:";
            // 
            // CriarJogadorButton
            // 
            this.CriarJogadorButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CriarJogadorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CriarJogadorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CriarJogadorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarJogadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CriarJogadorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CriarJogadorButton.Location = new System.Drawing.Point(60, 208);
            this.CriarJogadorButton.Name = "CriarJogadorButton";
            this.CriarJogadorButton.Size = new System.Drawing.Size(146, 42);
            this.CriarJogadorButton.TabIndex = 26;
            this.CriarJogadorButton.Text = "Criar jogador";
            this.CriarJogadorButton.UseVisualStyleBackColor = true;
            this.CriarJogadorButton.Click += new System.EventHandler(this.CriarJogadorButton_Click);
            // 
            // ListaDeJogadoresListBox
            // 
            this.ListaDeJogadoresListBox.FormattingEnabled = true;
            this.ListaDeJogadoresListBox.ItemHeight = 30;
            this.ListaDeJogadoresListBox.Location = new System.Drawing.Point(347, 120);
            this.ListaDeJogadoresListBox.Name = "ListaDeJogadoresListBox";
            this.ListaDeJogadoresListBox.Size = new System.Drawing.Size(265, 484);
            this.ListaDeJogadoresListBox.TabIndex = 24;
            // 
            // RemoverJogadorSelecionadoButton
            // 
            this.RemoverJogadorSelecionadoButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoverJogadorSelecionadoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoverJogadorSelecionadoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoverJogadorSelecionadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverJogadorSelecionadoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoverJogadorSelecionadoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RemoverJogadorSelecionadoButton.Location = new System.Drawing.Point(618, 324);
            this.RemoverJogadorSelecionadoButton.Name = "RemoverJogadorSelecionadoButton";
            this.RemoverJogadorSelecionadoButton.Size = new System.Drawing.Size(146, 70);
            this.RemoverJogadorSelecionadoButton.TabIndex = 25;
            this.RemoverJogadorSelecionadoButton.Text = "Remover Selecionado";
            this.RemoverJogadorSelecionadoButton.UseVisualStyleBackColor = true;
            this.RemoverJogadorSelecionadoButton.Click += new System.EventHandler(this.RemoverJogadorSelecionadoButton_Click);
            // 
            // CriarTimeButton
            // 
            this.CriarTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CriarTimeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CriarTimeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CriarTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarTimeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CriarTimeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CriarTimeButton.Location = new System.Drawing.Point(295, 633);
            this.CriarTimeButton.Name = "CriarTimeButton";
            this.CriarTimeButton.Size = new System.Drawing.Size(146, 42);
            this.CriarTimeButton.TabIndex = 27;
            this.CriarTimeButton.Text = "Criar Time";
            this.CriarTimeButton.UseVisualStyleBackColor = true;
            // 
            // SelecionarJogadorComboBox
            // 
            this.SelecionarJogadorComboBox.FormattingEnabled = true;
            this.SelecionarJogadorComboBox.Location = new System.Drawing.Point(30, 198);
            this.SelecionarJogadorComboBox.Name = "SelecionarJogadorComboBox";
            this.SelecionarJogadorComboBox.Size = new System.Drawing.Size(272, 38);
            this.SelecionarJogadorComboBox.TabIndex = 28;
            // 
            // FormularioCriarTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 687);
            this.Controls.Add(this.SelecionarJogadorComboBox);
            this.Controls.Add(this.CriarTimeButton);
            this.Controls.Add(this.RemoverJogadorSelecionadoButton);
            this.Controls.Add(this.ListaDeJogadoresListBox);
            this.Controls.Add(this.JogadorInformacoesGroupBox);
            this.Controls.Add(this.SelecionarJogadorLabel);
            this.Controls.Add(this.AdicionarJogadorButton);
            this.Controls.Add(this.NomeTimeTextBox);
            this.Controls.Add(this.NomeTimeLabel);
            this.Controls.Add(this.CabecalhoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormularioCriarTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criação dos Times";
            this.JogadorInformacoesGroupBox.ResumeLayout(false);
            this.JogadorInformacoesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdicionarJogadorButton;
        private System.Windows.Forms.TextBox NomeTimeTextBox;
        private System.Windows.Forms.Label NomeTimeLabel;
        private System.Windows.Forms.Label CabecalhoLabel;
        private System.Windows.Forms.Label SelecionarJogadorLabel;
        private System.Windows.Forms.GroupBox JogadorInformacoesGroupBox;
        private System.Windows.Forms.TextBox TelefoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox UltimoNomeTextBox;
        private System.Windows.Forms.TextBox PrimeiroNomeTextBox;
        private System.Windows.Forms.Label TelefoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label UltimoNomeLabel;
        private System.Windows.Forms.Label PrimeiroNomeLabel;
        private System.Windows.Forms.Button CriarJogadorButton;
        private System.Windows.Forms.ListBox ListaDeJogadoresListBox;
        private System.Windows.Forms.Button RemoverJogadorSelecionadoButton;
        private System.Windows.Forms.Button CriarTimeButton;
        private System.Windows.Forms.ComboBox SelecionarJogadorComboBox;
    }
}