using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv.view
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
            //exibe detalhes
            listViewCategoria.View = View.Details;
            // permite selecionar toda a linha
            listViewCategoria.FullRowSelect = true;
            // Exibe as linhas no listeview
            listViewCategoria.GridLines = true;
            // permitir ou não permitir que o usuario edite as linhas
            listViewCategoria.LabelEdit = false; //true para permitir edição em linhas

            listViewCategoria.Columns.Add("Nome Categoria", 400, HorizontalAlignment.Left);
            listViewCategoria.Columns.Add("id", 50, HorizontalAlignment.Left);
        }

        private void cBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
