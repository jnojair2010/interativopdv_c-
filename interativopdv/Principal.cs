using interativopdv.view;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            if(true)
            {
                Login();
            }
        }
        public void Login()
        {
            Login newLogin = new Login();
            newLogin.Show();
        
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void subcategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novasVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pdv pdv = new Pdv();
            pdv.Show();
        }

        private void productoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastrarProducto cp = new CadastrarProducto();
            cp.Show();
        }
    }

    
}
