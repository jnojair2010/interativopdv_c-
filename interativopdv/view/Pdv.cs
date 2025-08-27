using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv
{
    public partial class Pdv : Form
    {
        public Pdv()
        {
            InitializeComponent();

            //exibe detalhes
            listViewProducto.View = View.Details;
            // permite selecionar toda a linha
            listViewProducto.FullRowSelect = true;
            // Exibe as linhas no listeview
            listViewProducto.GridLines = true;
            // permitir ou não permitir que o usuario edite as linhas
            listViewProducto.LabelEdit = true;  //true para permitir edição em linhas

            listViewProducto.Columns.Add("Nome", 350, HorizontalAlignment.Left);
            listViewProducto.Columns.Add("Quant", 50, HorizontalAlignment.Left);
            listViewProducto.Columns.Add("Total", 100, HorizontalAlignment.Right);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_total_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisarProdutoDescricao = txtSearchProducto.Text;
            MessageBox.Show(" entrou na pesquisa do produto" + pesquisarProdutoDescricao);
        }

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string codigoBarra = txtCodBarra.Text;
            if (codigoBarra.Length>8 && codigoBarra.Length<14)
            {
                MessageBox.Show($"cliclou no evento {codigoBarra}");
            }
            
        }
    }
}
