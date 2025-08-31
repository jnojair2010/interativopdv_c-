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
    public partial class FundoTrocoInicial : Form
    {
        public FundoTrocoInicial()
        {
            InitializeComponent();
        }

        private void btnSalvarFundoTrocoInicio_Click(object sender, EventArgs e)
        {
            string fundodeTrocoInicial = txtFTrocoInicial.Text;


            this.Close();
        }
    }
}
