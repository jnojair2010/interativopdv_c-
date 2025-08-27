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
    public partial class SubCategorias : Form
    {
        public SubCategorias()
        {
            InitializeComponent();

            //exibe detalhes
            listViewSBC.View= View.Details;
            // permite selecionar toda a linha
            listViewSBC.FullRowSelect = true;
            // Exibe as linhas no listeview
            listViewSBC.GridLines = true;
            // permitir ou não permitir que o usuario edite as linhas
            listViewSBC.LabelEdit = true; //true para permitir edição em linhas

            listViewSBC.Columns.Add("Nome Sub-Categoria", 250, HorizontalAlignment.Left);
            listViewSBC.Columns.Add("id", 20, HorizontalAlignment.Left);
            listViewSBC.Columns.Add("Categoria Vinculada", 300, HorizontalAlignment.Left);
        }

        private void listViewSBC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
