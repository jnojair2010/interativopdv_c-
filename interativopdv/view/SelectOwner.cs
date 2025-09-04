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
    public partial class SelectOwner : Form
    {
        public SelectOwner()
        {
            InitializeComponent();
            listViewOwner.View = View.Details;

            listViewOwner.FullRowSelect = true;


            listViewOwner.GridLines = true;

            listViewOwner.LabelEdit = true;

            listViewOwner.Columns.Add("Nome", 433, HorizontalAlignment.Left);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
