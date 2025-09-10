namespace interativopdv.view
{
    partial class BindEmployeeCompany
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBMenuCaixa = new System.Windows.Forms.CheckBox();
            this.cBMenuProducto = new System.Windows.Forms.CheckBox();
            this.cBMenuFornecedor = new System.Windows.Forms.CheckBox();
            this.cBMenuColaborador = new System.Windows.Forms.CheckBox();
            this.cBMenuEmpresa = new System.Windows.Forms.CheckBox();
            this.cBViewPricePurchase = new System.Windows.Forms.CheckBox();
            this.cBRegistryPricePurchace = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grBindin = new System.Windows.Forms.GroupBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.grBoxVincular = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grBindin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 522);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBMenuCaixa);
            this.groupBox3.Controls.Add(this.cBMenuProducto);
            this.groupBox3.Controls.Add(this.cBMenuFornecedor);
            this.groupBox3.Controls.Add(this.cBMenuColaborador);
            this.groupBox3.Controls.Add(this.cBMenuEmpresa);
            this.groupBox3.Controls.Add(this.cBViewPricePurchase);
            this.groupBox3.Controls.Add(this.cBRegistryPricePurchace);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(139, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 150);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissoes";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cBMenuCaixa
            // 
            this.cBMenuCaixa.AutoSize = true;
            this.cBMenuCaixa.Location = new System.Drawing.Point(240, 85);
            this.cBMenuCaixa.Name = "cBMenuCaixa";
            this.cBMenuCaixa.Size = new System.Drawing.Size(111, 24);
            this.cBMenuCaixa.TabIndex = 6;
            this.cBMenuCaixa.Text = "Menu Caixa";
            this.cBMenuCaixa.UseVisualStyleBackColor = true;
            // 
            // cBMenuProducto
            // 
            this.cBMenuProducto.AutoSize = true;
            this.cBMenuProducto.Location = new System.Drawing.Point(240, 60);
            this.cBMenuProducto.Name = "cBMenuProducto";
            this.cBMenuProducto.Size = new System.Drawing.Size(128, 24);
            this.cBMenuProducto.TabIndex = 5;
            this.cBMenuProducto.Text = "Menu Produto";
            this.cBMenuProducto.UseVisualStyleBackColor = true;
            // 
            // cBMenuFornecedor
            // 
            this.cBMenuFornecedor.AutoSize = true;
            this.cBMenuFornecedor.Location = new System.Drawing.Point(240, 35);
            this.cBMenuFornecedor.Name = "cBMenuFornecedor";
            this.cBMenuFornecedor.Size = new System.Drawing.Size(154, 24);
            this.cBMenuFornecedor.TabIndex = 4;
            this.cBMenuFornecedor.Text = "Menu Fornecedor";
            this.cBMenuFornecedor.UseVisualStyleBackColor = true;
            // 
            // cBMenuColaborador
            // 
            this.cBMenuColaborador.AutoSize = true;
            this.cBMenuColaborador.Location = new System.Drawing.Point(47, 110);
            this.cBMenuColaborador.Name = "cBMenuColaborador";
            this.cBMenuColaborador.Size = new System.Drawing.Size(159, 24);
            this.cBMenuColaborador.TabIndex = 3;
            this.cBMenuColaborador.Text = "Menu Colaborador";
            this.cBMenuColaborador.UseVisualStyleBackColor = true;
            // 
            // cBMenuEmpresa
            // 
            this.cBMenuEmpresa.AutoSize = true;
            this.cBMenuEmpresa.Location = new System.Drawing.Point(47, 85);
            this.cBMenuEmpresa.Name = "cBMenuEmpresa";
            this.cBMenuEmpresa.Size = new System.Drawing.Size(136, 24);
            this.cBMenuEmpresa.TabIndex = 2;
            this.cBMenuEmpresa.Text = "Menu Empresa";
            this.cBMenuEmpresa.UseVisualStyleBackColor = true;
            // 
            // cBViewPricePurchase
            // 
            this.cBViewPricePurchase.AutoSize = true;
            this.cBViewPricePurchase.Location = new System.Drawing.Point(47, 60);
            this.cBViewPricePurchase.Name = "cBViewPricePurchase";
            this.cBViewPricePurchase.Size = new System.Drawing.Size(223, 24);
            this.cBViewPricePurchase.TabIndex = 1;
            this.cBViewPricePurchase.Text = "Visualizar Preço de Compra";
            this.cBViewPricePurchase.UseVisualStyleBackColor = true;
            // 
            // cBRegistryPricePurchace
            // 
            this.cBRegistryPricePurchace.AutoSize = true;
            this.cBRegistryPricePurchace.Location = new System.Drawing.Point(47, 35);
            this.cBRegistryPricePurchace.Name = "cBRegistryPricePurchace";
            this.cBRegistryPricePurchace.Size = new System.Drawing.Size(225, 24);
            this.cBRegistryPricePurchace.TabIndex = 0;
            this.cBRegistryPricePurchace.Text = "Cadastrar Preço de Compra";
            this.cBRegistryPricePurchace.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(284, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grBindin
            // 
            this.grBindin.Controls.Add(this.maskCnpj);
            this.grBindin.Controls.Add(this.label2);
            this.grBindin.Controls.Add(this.label1);
            this.grBindin.Controls.Add(this.mask_cpf);
            this.grBindin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBindin.Location = new System.Drawing.Point(139, 13);
            this.grBindin.Name = "grBindin";
            this.grBindin.Size = new System.Drawing.Size(457, 103);
            this.grBindin.TabIndex = 7;
            this.grBindin.TabStop = false;
            this.grBindin.Text = "Binding Associado ";
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(28, 52);
            this.mask_cpf.Mask = "000.000.000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(140, 26);
            this.mask_cpf.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Colaborador:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loja:";
            // 
            // maskCnpj
            // 
            this.maskCnpj.Location = new System.Drawing.Point(206, 51);
            this.maskCnpj.Mask = "00.000.000/0000-00";
            this.maskCnpj.Name = "maskCnpj";
            this.maskCnpj.Size = new System.Drawing.Size(242, 26);
            this.maskCnpj.TabIndex = 3;
            this.maskCnpj.Leave += new System.EventHandler(this.getEmpreendimentos);
            // 
            // grBoxVincular
            // 
            this.grBoxVincular.Location = new System.Drawing.Point(139, 123);
            this.grBoxVincular.Name = "grBoxVincular";
            this.grBoxVincular.Size = new System.Drawing.Size(457, 29);
            this.grBoxVincular.TabIndex = 8;
            this.grBoxVincular.TabStop = false;
            this.grBoxVincular.Text = "Vincular";
            // 
            // BindEmployeeCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 519);
            this.Controls.Add(this.grBoxVincular);
            this.Controls.Add(this.grBindin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BindEmployeeCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BindEmployeeCompany";
            this.Load += new System.EventHandler(this.BindEmployeeCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grBindin.ResumeLayout(false);
            this.grBindin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cBMenuCaixa;
        private System.Windows.Forms.CheckBox cBMenuProducto;
        private System.Windows.Forms.CheckBox cBMenuFornecedor;
        private System.Windows.Forms.CheckBox cBMenuColaborador;
        private System.Windows.Forms.CheckBox cBMenuEmpresa;
        private System.Windows.Forms.CheckBox cBViewPricePurchase;
        private System.Windows.Forms.CheckBox cBRegistryPricePurchace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grBindin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.MaskedTextBox maskCnpj;
        private System.Windows.Forms.GroupBox grBoxVincular;
    }
}