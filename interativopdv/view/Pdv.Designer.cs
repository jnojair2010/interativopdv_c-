namespace interativopdv
{
    partial class Pdv
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.lb_cod_barra = new System.Windows.Forms.Label();
            this.lbvunitario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_v_unitario = new System.Windows.Forms.Label();
            this.lb_tot_item = new System.Windows.Forms.Label();
            this.lb_v_total = new System.Windows.Forms.Label();
            this.lb_cod_interno = new System.Windows.Forms.Label();
            this.txt_cod_in = new System.Windows.Forms.TextBox();
            this.lb_of = new System.Windows.Forms.Label();
            this.txt_of = new System.Windows.Forms.TextBox();
            this.listViewProducto = new System.Windows.Forms.ListView();
            this.bl_subTotal = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.txtSearchProducto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 71);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(97, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interativo Pdv";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1087, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarra.Location = new System.Drawing.Point(230, 183);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(353, 44);
            this.txtCodBarra.TabIndex = 2;
            this.txtCodBarra.TextChanged += new System.EventHandler(this.txtCodBarra_TextChanged);
            this.txtCodBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarra_KeyPress);
            // 
            // lb_cod_barra
            // 
            this.lb_cod_barra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_cod_barra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cod_barra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_cod_barra.Location = new System.Drawing.Point(231, 150);
            this.lb_cod_barra.Name = "lb_cod_barra";
            this.lb_cod_barra.Size = new System.Drawing.Size(352, 30);
            this.lb_cod_barra.TabIndex = 5;
            this.lb_cod_barra.Text = "Codigo de Barra:";
            // 
            // lbvunitario
            // 
            this.lbvunitario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbvunitario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvunitario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbvunitario.Location = new System.Drawing.Point(231, 242);
            this.lbvunitario.Name = "lbvunitario";
            this.lbvunitario.Size = new System.Drawing.Size(351, 28);
            this.lbvunitario.TabIndex = 6;
            this.lbvunitario.Text = "Valor Unitário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(14, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 244);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lb_v_unitario
            // 
            this.lb_v_unitario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_v_unitario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_v_unitario.Location = new System.Drawing.Point(231, 270);
            this.lb_v_unitario.Name = "lb_v_unitario";
            this.lb_v_unitario.Size = new System.Drawing.Size(350, 38);
            this.lb_v_unitario.TabIndex = 8;
            this.lb_v_unitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tot_item
            // 
            this.lb_tot_item.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_tot_item.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tot_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_tot_item.Location = new System.Drawing.Point(233, 326);
            this.lb_tot_item.Name = "lb_tot_item";
            this.lb_tot_item.Size = new System.Drawing.Size(350, 29);
            this.lb_tot_item.TabIndex = 9;
            this.lb_tot_item.Text = "SubTotal:";
            // 
            // lb_v_total
            // 
            this.lb_v_total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_v_total.Location = new System.Drawing.Point(234, 355);
            this.lb_v_total.Name = "lb_v_total";
            this.lb_v_total.Size = new System.Drawing.Size(349, 38);
            this.lb_v_total.TabIndex = 10;
            // 
            // lb_cod_interno
            // 
            this.lb_cod_interno.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_cod_interno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cod_interno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_cod_interno.Location = new System.Drawing.Point(14, 405);
            this.lb_cod_interno.Name = "lb_cod_interno";
            this.lb_cod_interno.Size = new System.Drawing.Size(197, 27);
            this.lb_cod_interno.TabIndex = 11;
            this.lb_cod_interno.Text = "Codigo Interno";
            // 
            // txt_cod_in
            // 
            this.txt_cod_in.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_in.Location = new System.Drawing.Point(12, 438);
            this.txt_cod_in.Name = "txt_cod_in";
            this.txt_cod_in.Size = new System.Drawing.Size(198, 44);
            this.txt_cod_in.TabIndex = 12;
            // 
            // lb_of
            // 
            this.lb_of.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_of.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_of.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_of.Location = new System.Drawing.Point(233, 405);
            this.lb_of.Name = "lb_of";
            this.lb_of.Size = new System.Drawing.Size(350, 30);
            this.lb_of.TabIndex = 13;
            this.lb_of.Text = "Desconto";
            // 
            // txt_of
            // 
            this.txt_of.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_of.Location = new System.Drawing.Point(231, 438);
            this.txt_of.Name = "txt_of";
            this.txt_of.Size = new System.Drawing.Size(353, 44);
            this.txt_of.TabIndex = 14;
            // 
            // listViewProducto
            // 
            this.listViewProducto.HideSelection = false;
            this.listViewProducto.Location = new System.Drawing.Point(619, 166);
            this.listViewProducto.Name = "listViewProducto";
            this.listViewProducto.Size = new System.Drawing.Size(508, 515);
            this.listViewProducto.TabIndex = 15;
            this.listViewProducto.UseCompatibleStateImageBehavior = false;
            // 
            // bl_subTotal
            // 
            this.bl_subTotal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bl_subTotal.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_subTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bl_subTotal.Location = new System.Drawing.Point(619, 99);
            this.bl_subTotal.Name = "bl_subTotal";
            this.bl_subTotal.Size = new System.Drawing.Size(123, 57);
            this.bl_subTotal.TabIndex = 17;
            this.bl_subTotal.Text = "Total";
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_total.Font = new System.Drawing.Font("News701 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(748, 100);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(379, 56);
            this.lb_total.TabIndex = 18;
            this.lb_total.Click += new System.EventHandler(this.lb_total_Click);
            // 
            // txtSearchProducto
            // 
            this.txtSearchProducto.Font = new System.Drawing.Font("News701 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProducto.Location = new System.Drawing.Point(12, 81);
            this.txtSearchProducto.Name = "txtSearchProducto";
            this.txtSearchProducto.Size = new System.Drawing.Size(436, 40);
            this.txtSearchProducto.TabIndex = 19;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Location = new System.Drawing.Point(454, 81);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(127, 42);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("News701 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(131, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 56);
            this.button2.TabIndex = 21;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dinheiro",
            "Debito",
            "Credito",
            "Pix",
            "Troca",
            "Vale",
            "Fiado"});
            this.comboBox1.Location = new System.Drawing.Point(234, 523);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Forma de pagamento";
            // 
            // Pdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1155, 705);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtSearchProducto);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.bl_subTotal);
            this.Controls.Add(this.listViewProducto);
            this.Controls.Add(this.txt_of);
            this.Controls.Add(this.lb_of);
            this.Controls.Add(this.txt_cod_in);
            this.Controls.Add(this.lb_cod_interno);
            this.Controls.Add(this.lb_v_total);
            this.Controls.Add(this.lb_tot_item);
            this.Controls.Add(this.lb_v_unitario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbvunitario);
            this.Controls.Add(this.lb_cod_barra);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("News701 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Pdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.Label lb_cod_barra;
        private System.Windows.Forms.Label lbvunitario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_v_unitario;
        private System.Windows.Forms.Label lb_tot_item;
        private System.Windows.Forms.Label lb_v_total;
        private System.Windows.Forms.Label lb_cod_interno;
        private System.Windows.Forms.TextBox txt_cod_in;
        private System.Windows.Forms.Label lb_of;
        private System.Windows.Forms.TextBox txt_of;
        private System.Windows.Forms.ListView listViewProducto;
        private System.Windows.Forms.Label bl_subTotal;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TextBox txtSearchProducto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

