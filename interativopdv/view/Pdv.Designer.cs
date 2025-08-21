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
            this.lbDispNProducto = new System.Windows.Forms.Label();
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_add = new System.Windows.Forms.Button();
            this.bl_subTotal = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(1376, 71);
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
            this.button1.Location = new System.Drawing.Point(1272, 12);
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
            this.txtCodBarra.Location = new System.Drawing.Point(460, 218);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(353, 44);
            this.txtCodBarra.TabIndex = 2;
            this.txtCodBarra.TextChanged += new System.EventHandler(this.txtCodBarra_TextChanged);
            // 
            // lbDispNProducto
            // 
            this.lbDispNProducto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbDispNProducto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDispNProducto.Location = new System.Drawing.Point(12, 115);
            this.lbDispNProducto.Name = "lbDispNProducto";
            this.lbDispNProducto.Size = new System.Drawing.Size(800, 60);
            this.lbDispNProducto.TabIndex = 4;
            this.lbDispNProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_cod_barra
            // 
            this.lb_cod_barra.BackColor = System.Drawing.Color.ForestGreen;
            this.lb_cod_barra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cod_barra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_cod_barra.Location = new System.Drawing.Point(460, 187);
            this.lb_cod_barra.Name = "lb_cod_barra";
            this.lb_cod_barra.Size = new System.Drawing.Size(352, 30);
            this.lb_cod_barra.TabIndex = 5;
            this.lb_cod_barra.Text = "Codigo de Barra:";
            // 
            // lbvunitario
            // 
            this.lbvunitario.BackColor = System.Drawing.Color.ForestGreen;
            this.lbvunitario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvunitario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbvunitario.Location = new System.Drawing.Point(461, 290);
            this.lbvunitario.Name = "lbvunitario";
            this.lbvunitario.Size = new System.Drawing.Size(351, 28);
            this.lbvunitario.TabIndex = 6;
            this.lbvunitario.Text = "Valor Unitário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(18, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 450);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lb_v_unitario
            // 
            this.lb_v_unitario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_v_unitario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_v_unitario.Location = new System.Drawing.Point(462, 319);
            this.lb_v_unitario.Name = "lb_v_unitario";
            this.lb_v_unitario.Size = new System.Drawing.Size(350, 38);
            this.lb_v_unitario.TabIndex = 8;
            this.lb_v_unitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tot_item
            // 
            this.lb_tot_item.BackColor = System.Drawing.Color.ForestGreen;
            this.lb_tot_item.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tot_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_tot_item.Location = new System.Drawing.Point(461, 385);
            this.lb_tot_item.Name = "lb_tot_item";
            this.lb_tot_item.Size = new System.Drawing.Size(350, 29);
            this.lb_tot_item.TabIndex = 9;
            this.lb_tot_item.Text = "Total";
            // 
            // lb_v_total
            // 
            this.lb_v_total.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_v_total.Location = new System.Drawing.Point(461, 416);
            this.lb_v_total.Name = "lb_v_total";
            this.lb_v_total.Size = new System.Drawing.Size(349, 38);
            this.lb_v_total.TabIndex = 10;
            // 
            // lb_cod_interno
            // 
            this.lb_cod_interno.BackColor = System.Drawing.Color.ForestGreen;
            this.lb_cod_interno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cod_interno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_cod_interno.Location = new System.Drawing.Point(460, 470);
            this.lb_cod_interno.Name = "lb_cod_interno";
            this.lb_cod_interno.Size = new System.Drawing.Size(352, 27);
            this.lb_cod_interno.TabIndex = 11;
            this.lb_cod_interno.Text = "Codigo Interno";
            // 
            // txt_cod_in
            // 
            this.txt_cod_in.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_in.Location = new System.Drawing.Point(460, 497);
            this.txt_cod_in.Name = "txt_cod_in";
            this.txt_cod_in.Size = new System.Drawing.Size(353, 44);
            this.txt_cod_in.TabIndex = 12;
            // 
            // lb_of
            // 
            this.lb_of.BackColor = System.Drawing.Color.ForestGreen;
            this.lb_of.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_of.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_of.Location = new System.Drawing.Point(460, 558);
            this.lb_of.Name = "lb_of";
            this.lb_of.Size = new System.Drawing.Size(350, 30);
            this.lb_of.TabIndex = 13;
            this.lb_of.Text = "Desconto";
            // 
            // txt_of
            // 
            this.txt_of.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_of.Location = new System.Drawing.Point(460, 589);
            this.txt_of.Name = "txt_of";
            this.txt_of.Size = new System.Drawing.Size(353, 44);
            this.txt_of.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(849, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(526, 581);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(460, 640);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(353, 56);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add Carrinho";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // bl_subTotal
            // 
            this.bl_subTotal.BackColor = System.Drawing.Color.ForestGreen;
            this.bl_subTotal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_subTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bl_subTotal.Location = new System.Drawing.Point(26, 700);
            this.bl_subTotal.Name = "bl_subTotal";
            this.bl_subTotal.Size = new System.Drawing.Size(414, 29);
            this.bl_subTotal.TabIndex = 17;
            this.bl_subTotal.Text = "SubTotal";
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_total.Font = new System.Drawing.Font("News701 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(28, 728);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(410, 40);
            this.lb_total.TabIndex = 18;
            // 
            // Pdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1383, 793);
            this.ControlBox = false;
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.bl_subTotal);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listView1);
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
            this.Controls.Add(this.lbDispNProducto);
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
        private System.Windows.Forms.Label lbDispNProducto;
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label bl_subTotal;
        private System.Windows.Forms.Label lb_total;
    }
}

