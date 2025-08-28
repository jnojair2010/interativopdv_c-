namespace interativopdv.view
{
    partial class Categorias
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
            this.lbCategoriaName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.listViewCategoria = new System.Windows.Forms.ListView();
            this.btnClearCategoria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.lbCategoriaName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Location = new System.Drawing.Point(147, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // lbCategoriaName
            // 
            this.lbCategoriaName.AutoSize = true;
            this.lbCategoriaName.Location = new System.Drawing.Point(6, 26);
            this.lbCategoriaName.Name = "lbCategoriaName";
            this.lbCategoriaName.Size = new System.Drawing.Size(38, 13);
            this.lbCategoriaName.TabIndex = 0;
            this.lbCategoriaName.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(356, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(6, 42);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(202, 20);
            this.txtCategoria.TabIndex = 1;
            // 
            // listViewCategoria
            // 
            this.listViewCategoria.HideSelection = false;
            this.listViewCategoria.Location = new System.Drawing.Point(147, 111);
            this.listViewCategoria.Name = "listViewCategoria";
            this.listViewCategoria.Size = new System.Drawing.Size(479, 282);
            this.listViewCategoria.TabIndex = 4;
            this.listViewCategoria.UseCompatibleStateImageBehavior = false;
            // 
            // btnClearCategoria
            // 
            this.btnClearCategoria.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClearCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearCategoria.Location = new System.Drawing.Point(503, 399);
            this.btnClearCategoria.Name = "btnClearCategoria";
            this.btnClearCategoria.Size = new System.Drawing.Size(117, 40);
            this.btnClearCategoria.TabIndex = 5;
            this.btnClearCategoria.Text = "Limpar";
            this.btnClearCategoria.UseVisualStyleBackColor = false;
            this.btnClearCategoria.Click += new System.EventHandler(this.btnClearCategoria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 451);
            this.Controls.Add(this.btnClearCategoria);
            this.Controls.Add(this.listViewCategoria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lbCategoriaName;
        private System.Windows.Forms.ListView listViewCategoria;
        private System.Windows.Forms.Button btnClearCategoria;
    }
}