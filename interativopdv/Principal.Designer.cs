namespace interativopdv
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novasVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fTrocoIncialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTrocoFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sangriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.caixaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novasVendasToolStripMenuItem,
            this.consultarVendasToolStripMenuItem,
            this.deletarVendasToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // novasVendasToolStripMenuItem
            // 
            this.novasVendasToolStripMenuItem.Name = "novasVendasToolStripMenuItem";
            this.novasVendasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.novasVendasToolStripMenuItem.Text = "Novas Vendas";
            this.novasVendasToolStripMenuItem.Click += new System.EventHandler(this.novasVendasToolStripMenuItem_Click);
            // 
            // consultarVendasToolStripMenuItem
            // 
            this.consultarVendasToolStripMenuItem.Name = "consultarVendasToolStripMenuItem";
            this.consultarVendasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.consultarVendasToolStripMenuItem.Text = "Consultar Vendas";
            // 
            // deletarVendasToolStripMenuItem
            // 
            this.deletarVendasToolStripMenuItem.Name = "deletarVendasToolStripMenuItem";
            this.deletarVendasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.deletarVendasToolStripMenuItem.Text = "Deletar Vendas";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.consultarToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.cadastrarToolStripMenuItem.Text = "Producto";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.subCategoriaToolStripMenuItem});
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click_1);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem1,
            this.categoriaToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(147, 26);
            this.productoToolStripMenuItem1.Text = "Producto";
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(147, 26);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem2,
            this.sangriaToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTrocoIncialToolStripMenuItem,
            this.fTrocoFinalToolStripMenuItem});
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(147, 26);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
            // 
            // fTrocoIncialToolStripMenuItem
            // 
            this.fTrocoIncialToolStripMenuItem.Name = "fTrocoIncialToolStripMenuItem";
            this.fTrocoIncialToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.fTrocoIncialToolStripMenuItem.Text = "F. Troco Incial";
            // 
            // fTrocoFinalToolStripMenuItem
            // 
            this.fTrocoFinalToolStripMenuItem.Name = "fTrocoFinalToolStripMenuItem";
            this.fTrocoFinalToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.fTrocoFinalToolStripMenuItem.Text = "F. Troco Final";
            // 
            // sangriaToolStripMenuItem
            // 
            this.sangriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem});
            this.sangriaToolStripMenuItem.Name = "sangriaToolStripMenuItem";
            this.sangriaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.sangriaToolStripMenuItem.Text = "Sangria";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // subCategoriaToolStripMenuItem
            // 
            this.subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            this.subCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.subCategoriaToolStripMenuItem.Text = "Sub Categoria";
            this.subCategoriaToolStripMenuItem.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1484, 821);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novasVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fTrocoIncialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTrocoFinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sangriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem;
    }
}