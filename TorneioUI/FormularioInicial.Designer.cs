
namespace TorneioUI
{
    partial class FormularioInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioInicial));
            this.CarregarTorneioButton = new System.Windows.Forms.Button();
            this.CarregarTorneioLabel = new System.Windows.Forms.Label();
            this.CabecalhoLabel = new System.Windows.Forms.Label();
            this.CriarTorneioButton = new System.Windows.Forms.Button();
            this.CarregarTorneioComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CarregarTorneioButton
            // 
            this.CarregarTorneioButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CarregarTorneioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CarregarTorneioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CarregarTorneioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarregarTorneioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarregarTorneioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CarregarTorneioButton.Location = new System.Drawing.Point(183, 225);
            this.CarregarTorneioButton.Name = "CarregarTorneioButton";
            this.CarregarTorneioButton.Size = new System.Drawing.Size(157, 72);
            this.CarregarTorneioButton.TabIndex = 35;
            this.CarregarTorneioButton.Text = "Carregar Torneio";
            this.CarregarTorneioButton.UseVisualStyleBackColor = true;
            // 
            // CarregarTorneioLabel
            // 
            this.CarregarTorneioLabel.AutoSize = true;
            this.CarregarTorneioLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarregarTorneioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CarregarTorneioLabel.Location = new System.Drawing.Point(100, 117);
            this.CarregarTorneioLabel.Name = "CarregarTorneioLabel";
            this.CarregarTorneioLabel.Size = new System.Drawing.Size(332, 37);
            this.CarregarTorneioLabel.TabIndex = 33;
            this.CarregarTorneioLabel.Text = "Carregar Torneio Existente:";
            // 
            // CabecalhoLabel
            // 
            this.CabecalhoLabel.AutoSize = true;
            this.CabecalhoLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CabecalhoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CabecalhoLabel.Location = new System.Drawing.Point(2, 9);
            this.CabecalhoLabel.Name = "CabecalhoLabel";
            this.CabecalhoLabel.Size = new System.Drawing.Size(512, 50);
            this.CabecalhoLabel.TabIndex = 32;
            this.CabecalhoLabel.Text = "Bem vindo ao Torneio do Bruxo";
            // 
            // CriarTorneioButton
            // 
            this.CriarTorneioButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CriarTorneioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CriarTorneioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CriarTorneioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarTorneioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CriarTorneioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CriarTorneioButton.Location = new System.Drawing.Point(183, 303);
            this.CriarTorneioButton.Name = "CriarTorneioButton";
            this.CriarTorneioButton.Size = new System.Drawing.Size(157, 44);
            this.CriarTorneioButton.TabIndex = 36;
            this.CriarTorneioButton.Text = "Criar Torneio";
            this.CriarTorneioButton.UseVisualStyleBackColor = true;
            // 
            // CarregarTorneioComboBox
            // 
            this.CarregarTorneioComboBox.FormattingEnabled = true;
            this.CarregarTorneioComboBox.Location = new System.Drawing.Point(125, 157);
            this.CarregarTorneioComboBox.Name = "CarregarTorneioComboBox";
            this.CarregarTorneioComboBox.Size = new System.Drawing.Size(278, 38);
            this.CarregarTorneioComboBox.TabIndex = 37;
            // 
            // FormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 411);
            this.Controls.Add(this.CarregarTorneioComboBox);
            this.Controls.Add(this.CriarTorneioButton);
            this.Controls.Add(this.CarregarTorneioButton);
            this.Controls.Add(this.CarregarTorneioLabel);
            this.Controls.Add(this.CabecalhoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormularioInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rastreador de Torneio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CarregarTorneioButton;
        private System.Windows.Forms.Label CarregarTorneioLabel;
        private System.Windows.Forms.Label CabecalhoLabel;
        private System.Windows.Forms.Button CriarTorneioButton;
        private System.Windows.Forms.ComboBox CarregarTorneioComboBox;
    }
}