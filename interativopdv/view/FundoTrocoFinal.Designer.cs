namespace interativopdv.view
{
    partial class FundoTrocoFinal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvefundoTrocoFim = new System.Windows.Forms.Button();
            this.txtFundoTrocoFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalvefundoTrocoFim);
            this.groupBox2.Controls.Add(this.txtFundoTrocoFinal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(151, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fundo de Troco Final";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSalvefundoTrocoFim
            // 
            this.btnSalvefundoTrocoFim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvefundoTrocoFim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvefundoTrocoFim.Location = new System.Drawing.Point(253, 56);
            this.btnSalvefundoTrocoFim.Name = "btnSalvefundoTrocoFim";
            this.btnSalvefundoTrocoFim.Size = new System.Drawing.Size(106, 41);
            this.btnSalvefundoTrocoFim.TabIndex = 2;
            this.btnSalvefundoTrocoFim.Text = "Salvar";
            this.btnSalvefundoTrocoFim.UseVisualStyleBackColor = false;
            this.btnSalvefundoTrocoFim.Click += new System.EventHandler(this.btnSalvefundoTrocoFim_Click);
            // 
            // txtFundoTrocoFinal
            // 
            this.txtFundoTrocoFinal.Location = new System.Drawing.Point(29, 65);
            this.txtFundoTrocoFinal.Name = "txtFundoTrocoFinal";
            this.txtFundoTrocoFinal.Size = new System.Drawing.Size(218, 22);
            this.txtFundoTrocoFinal.TabIndex = 1;
            this.txtFundoTrocoFinal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 145);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FundoTrocoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 146);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FundoTrocoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FundoTrocoFinal";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvefundoTrocoFim;
        private System.Windows.Forms.TextBox txtFundoTrocoFinal;
        private System.Windows.Forms.Label label2;
    }
}