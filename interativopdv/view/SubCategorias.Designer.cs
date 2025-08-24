namespace interativopdv.view
{
    partial class SubCategorias
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarSbC = new System.Windows.Forms.Button();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSBC = new System.Windows.Forms.ListView();
            this.btnClearSbC = new System.Windows.Forms.Button();
            this.cBoxSelectCategorias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 451);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxSelectCategorias);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSalvarSbC);
            this.groupBox1.Controls.Add(this.txtSubCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(136, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sub Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria vinculante";
            // 
            // btnSalvarSbC
            // 
            this.btnSalvarSbC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvarSbC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarSbC.Location = new System.Drawing.Point(313, 86);
            this.btnSalvarSbC.Name = "btnSalvarSbC";
            this.btnSalvarSbC.Size = new System.Drawing.Size(117, 43);
            this.btnSalvarSbC.TabIndex = 2;
            this.btnSalvarSbC.Text = "Salvar";
            this.btnSalvarSbC.UseVisualStyleBackColor = false;
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.Location = new System.Drawing.Point(18, 105);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(215, 22);
            this.txtSubCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // listViewSBC
            // 
            this.listViewSBC.HideSelection = false;
            this.listViewSBC.Location = new System.Drawing.Point(136, 154);
            this.listViewSBC.Name = "listViewSBC";
            this.listViewSBC.Size = new System.Drawing.Size(440, 242);
            this.listViewSBC.TabIndex = 2;
            this.listViewSBC.UseCompatibleStateImageBehavior = false;
            // 
            // btnClearSbC
            // 
            this.btnClearSbC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClearSbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSbC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearSbC.Location = new System.Drawing.Point(451, 403);
            this.btnClearSbC.Name = "btnClearSbC";
            this.btnClearSbC.Size = new System.Drawing.Size(117, 43);
            this.btnClearSbC.TabIndex = 3;
            this.btnClearSbC.Text = "Limpar";
            this.btnClearSbC.UseVisualStyleBackColor = false;
            // 
            // cBoxSelectCategorias
            // 
            this.cBoxSelectCategorias.FormattingEnabled = true;
            this.cBoxSelectCategorias.Location = new System.Drawing.Point(17, 57);
            this.cBoxSelectCategorias.Name = "cBoxSelectCategorias";
            this.cBoxSelectCategorias.Size = new System.Drawing.Size(252, 24);
            this.cBoxSelectCategorias.TabIndex = 4;
            this.cBoxSelectCategorias.Text = "Selecione uma categoria vinculante";
            // 
            // SubCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.btnClearSbC);
            this.Controls.Add(this.listViewSBC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SubCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSubCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarSbC;
        private System.Windows.Forms.ListView listViewSBC;
        private System.Windows.Forms.Button btnClearSbC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxSelectCategorias;
    }
}