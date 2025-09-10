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
            this.maskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskCpfEmployee = new System.Windows.Forms.MaskedTextBox();
            this.cBoxSelectFuncao = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmailColab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSobrenomeColab = new System.Windows.Forms.TextBox();
            this.lblSobrenomeColab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNomeColaborador = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.txtComplColab = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstadoColab = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairroColab = new System.Windows.Forms.TextBox();
            this.txtCidadeColab = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCepColab = new System.Windows.Forms.TextBox();
            this.txtEndNumbe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogradouroColab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarColaborador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskDataNasc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskCpfEmployee);
            this.groupBox1.Controls.Add(this.cBoxSelectFuncao);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtEmailColab);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSobrenomeColab);
            this.groupBox1.Controls.Add(this.lblSobrenomeColab);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblNomeColaborador);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(154, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoas";
            // 
            // maskDataNasc
            // 
            this.maskDataNasc.Location = new System.Drawing.Point(260, 146);
            this.maskDataNasc.Mask = "00/00/0000";
            this.maskDataNasc.Name = "maskDataNasc";
            this.maskDataNasc.Size = new System.Drawing.Size(126, 22);
            this.maskDataNasc.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data Nasc:";
            // 
            // maskCpfEmployee
            // 
            this.maskCpfEmployee.Location = new System.Drawing.Point(33, 92);
            this.maskCpfEmployee.Mask = "000.000.000-00";
            this.maskCpfEmployee.Name = "maskCpfEmployee";
            this.maskCpfEmployee.Size = new System.Drawing.Size(189, 22);
            this.maskCpfEmployee.TabIndex = 17;
            // 
            // cBoxSelectFuncao
            // 
            this.cBoxSelectFuncao.FormattingEnabled = true;
            this.cBoxSelectFuncao.Location = new System.Drawing.Point(33, 145);
            this.cBoxSelectFuncao.Name = "cBoxSelectFuncao";
            this.cBoxSelectFuncao.Size = new System.Drawing.Size(183, 24);
            this.cBoxSelectFuncao.TabIndex = 15;
            this.cBoxSelectFuncao.Text = "Selecione uma Atividade";
            this.cBoxSelectFuncao.SelectedIndexChanged += new System.EventHandler(this.cBoxSelectFuncao_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(413, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ativo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Função:";
            // 
            // txtEmailColab
            // 
            this.txtEmailColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailColab.Location = new System.Drawing.Point(257, 92);
            this.txtEmailColab.Name = "txtEmailColab";
            this.txtEmailColab.Size = new System.Drawing.Size(214, 22);
            this.txtEmailColab.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // txtSobrenomeColab
            // 
            this.txtSobrenomeColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenomeColab.Location = new System.Drawing.Point(257, 41);
            this.txtSobrenomeColab.Name = "txtSobrenomeColab";
            this.txtSobrenomeColab.Size = new System.Drawing.Size(214, 22);
            this.txtSobrenomeColab.TabIndex = 7;
            // 
            // lblSobrenomeColab
            // 
            this.lblSobrenomeColab.AutoSize = true;
            this.lblSobrenomeColab.Location = new System.Drawing.Point(253, 25);
            this.lblSobrenomeColab.Name = "lblSobrenomeColab";
            this.lblSobrenomeColab.Size = new System.Drawing.Size(81, 16);
            this.lblSobrenomeColab.TabIndex = 6;
            this.lblSobrenomeColab.Text = "Sobrenome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(33, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblNomeColaborador
            // 
            this.lblNomeColaborador.AutoSize = true;
            this.lblNomeColaborador.Location = new System.Drawing.Point(30, 25);
            this.lblNomeColaborador.Name = "lblNomeColaborador";
            this.lblNomeColaborador.Size = new System.Drawing.Size(47, 16);
            this.lblNomeColaborador.TabIndex = 0;
            this.lblNomeColaborador.Text = "Nome:";
            this.lblNomeColaborador.Click += new System.EventHandler(this.lblNomeColaborador_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox3);
            this.groupBox2.Controls.Add(this.txtComplColab);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtEstadoColab);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBairroColab);
            this.groupBox2.Controls.Add(this.txtCidadeColab);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCepColab);
            this.groupBox2.Controls.Add(this.txtEndNumbe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLogradouroColab);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(154, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(240, 101);
            this.maskedTextBox3.Mask = "00.000-000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(214, 22);
            this.maskedTextBox3.TabIndex = 14;
            // 
            // txtComplColab
            // 
            this.txtComplColab.AcceptsReturn = true;
            this.txtComplColab.Location = new System.Drawing.Point(240, 211);
            this.txtComplColab.Name = "txtComplColab";
            this.txtComplColab.Size = new System.Drawing.Size(214, 22);
            this.txtComplColab.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Complemento:";
            // 
            // txtEstadoColab
            // 
            this.txtEstadoColab.Location = new System.Drawing.Point(47, 212);
            this.txtEstadoColab.Name = "txtEstadoColab";
            this.txtEstadoColab.Size = new System.Drawing.Size(187, 22);
            this.txtEstadoColab.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Estado:";
            // 
            // txtBairroColab
            // 
            this.txtBairroColab.Location = new System.Drawing.Point(44, 156);
            this.txtBairroColab.Name = "txtBairroColab";
            this.txtBairroColab.Size = new System.Drawing.Size(190, 22);
            this.txtBairroColab.TabIndex = 9;
            // 
            // txtCidadeColab
            // 
            this.txtCidadeColab.Location = new System.Drawing.Point(240, 156);
            this.txtCidadeColab.Name = "txtCidadeColab";
            this.txtCidadeColab.Size = new System.Drawing.Size(214, 22);
            this.txtCidadeColab.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bairro:";
            // 
            // txtCepColab
            // 
            this.txtCepColab.Location = new System.Drawing.Point(240, 101);
            this.txtCepColab.Name = "txtCepColab";
            this.txtCepColab.Size = new System.Drawing.Size(214, 22);
            this.txtCepColab.TabIndex = 5;
            // 
            // txtEndNumbe
            // 
            this.txtEndNumbe.Location = new System.Drawing.Point(44, 101);
            this.txtEndNumbe.Name = "txtEndNumbe";
            this.txtEndNumbe.Size = new System.Drawing.Size(190, 22);
            this.txtEndNumbe.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cep:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Numero:";
            // 
            // txtLogradouroColab
            // 
            this.txtLogradouroColab.Location = new System.Drawing.Point(44, 51);
            this.txtLogradouroColab.Name = "txtLogradouroColab";
            this.txtLogradouroColab.Size = new System.Drawing.Size(410, 22);
            this.txtLogradouroColab.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Logradouro:";
            // 
            // btnSalvarColaborador
            // 
            this.btnSalvarColaborador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvarColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarColaborador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarColaborador.Location = new System.Drawing.Point(320, 479);
            this.btnSalvarColaborador.Name = "btnSalvarColaborador";
            this.btnSalvarColaborador.Size = new System.Drawing.Size(106, 40);
            this.btnSalvarColaborador.TabIndex = 2;
            this.btnSalvarColaborador.Text = "Salvar";
            this.btnSalvarColaborador.UseVisualStyleBackColor = false;
            this.btnSalvarColaborador.Click += new System.EventHandler(this.btnSalvarColaborador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 533);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvarColaborador);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastrarColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Colaborador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvarColaborador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNomeColaborador;
        private System.Windows.Forms.TextBox txtEmailColab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSobrenomeColab;
        private System.Windows.Forms.Label lblSobrenomeColab;
        private System.Windows.Forms.TextBox txtLogradouroColab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCepColab;
        private System.Windows.Forms.TextBox txtEndNumbe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBairroColab;
        private System.Windows.Forms.TextBox txtCidadeColab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstadoColab;
        private System.Windows.Forms.TextBox txtComplColab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cBoxSelectFuncao;
        private System.Windows.Forms.MaskedTextBox maskCpfEmployee;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskDataNasc;
    }
}