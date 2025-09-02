namespace interativopdv.view
{
    partial class Empreendedor
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
            this.btnSalvarEmpreendedor = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSobreNameEntrepreneur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameEntrepreneur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvarEmpreendedor);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSobreNameEntrepreneur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNameEntrepreneur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(148, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoas";
            // 
            // btnSalvarEmpreendedor
            // 
            this.btnSalvarEmpreendedor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvarEmpreendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarEmpreendedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarEmpreendedor.Location = new System.Drawing.Point(183, 227);
            this.btnSalvarEmpreendedor.Name = "btnSalvarEmpreendedor";
            this.btnSalvarEmpreendedor.Size = new System.Drawing.Size(106, 40);
            this.btnSalvarEmpreendedor.TabIndex = 6;
            this.btnSalvarEmpreendedor.Text = "Salvar";
            this.btnSalvarEmpreendedor.UseVisualStyleBackColor = false;
            this.btnSalvarEmpreendedor.Click += new System.EventHandler(this.btnSalvarEmpreendedor_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(36, 181);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(443, 22);
            this.txtCpf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // txtSobreNameEntrepreneur
            // 
            this.txtSobreNameEntrepreneur.Location = new System.Drawing.Point(36, 122);
            this.txtSobreNameEntrepreneur.Name = "txtSobreNameEntrepreneur";
            this.txtSobreNameEntrepreneur.Size = new System.Drawing.Size(443, 22);
            this.txtSobreNameEntrepreneur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobre Nome:";
            // 
            // txtNameEntrepreneur
            // 
            this.txtNameEntrepreneur.Location = new System.Drawing.Point(33, 59);
            this.txtNameEntrepreneur.Name = "txtNameEntrepreneur";
            this.txtNameEntrepreneur.Size = new System.Drawing.Size(446, 22);
            this.txtNameEntrepreneur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 330);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Empreendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Empreendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empreendedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameEntrepreneur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarEmpreendedor;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSobreNameEntrepreneur;
    }
}