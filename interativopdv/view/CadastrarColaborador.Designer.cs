namespace interativopdv.view
{
    partial class CadastrarColaborador
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvarColaborador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoas";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(27, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // btnSalvarColaborador
            // 
            this.btnSalvarColaborador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvarColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarColaborador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarColaborador.Location = new System.Drawing.Point(218, 670);
            this.btnSalvarColaborador.Name = "btnSalvarColaborador";
            this.btnSalvarColaborador.Size = new System.Drawing.Size(125, 45);
            this.btnSalvarColaborador.TabIndex = 2;
            this.btnSalvarColaborador.Text = "Salvar";
            this.btnSalvarColaborador.UseVisualStyleBackColor = false;
            // 
            // CadastrarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 741);
            this.Controls.Add(this.btnSalvarColaborador);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastrarColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Colaborador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvarColaborador;
    }
}