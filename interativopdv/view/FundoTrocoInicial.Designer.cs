namespace interativopdv.view
{
    partial class FundoTrocoInicial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvarFundoTrocoInicio = new System.Windows.Forms.Button();
            this.txtFTrocoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvarFundoTrocoInicio);
            this.groupBox1.Controls.Add(this.txtFTrocoInicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(153, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(368, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fundo de Troco inicial";
            // 
            // btnSalvarFundoTrocoInicio
            // 
            this.btnSalvarFundoTrocoInicio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvarFundoTrocoInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarFundoTrocoInicio.Location = new System.Drawing.Point(253, 54);
            this.btnSalvarFundoTrocoInicio.Name = "btnSalvarFundoTrocoInicio";
            this.btnSalvarFundoTrocoInicio.Size = new System.Drawing.Size(106, 41);
            this.btnSalvarFundoTrocoInicio.TabIndex = 2;
            this.btnSalvarFundoTrocoInicio.Text = "Salvar";
            this.btnSalvarFundoTrocoInicio.UseVisualStyleBackColor = false;
            this.btnSalvarFundoTrocoInicio.Click += new System.EventHandler(this.btnSalvarFundoTrocoInicio_Click);
            // 
            // txtFTrocoInicial
            // 
            this.txtFTrocoInicial.Location = new System.Drawing.Point(29, 63);
            this.txtFTrocoInicial.Name = "txtFTrocoInicial";
            this.txtFTrocoInicial.Size = new System.Drawing.Size(218, 22);
            this.txtFTrocoInicial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FundoTrocoInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 145);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FundoTrocoInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FundoTroco";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvarFundoTrocoInicio;
        private System.Windows.Forms.TextBox txtFTrocoInicial;
        private System.Windows.Forms.Label label1;
    }
}