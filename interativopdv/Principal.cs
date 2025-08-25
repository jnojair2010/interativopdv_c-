using interativopdv.model;
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
            newLogin.MdiParent = this;
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
            cp.MdiParent = this;
            cp.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            cat.MdiParent = this;
            cat.Show();
           
        }

        private void subCategoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SubCategorias sub = new SubCategorias();
            sub.MdiParent = this;
            sub.Show();
        }

        private void onClickAbriJanelaFundoTroco(object sender, EventArgs e)
        {
            FundoTroco fundo = new FundoTroco();
            fundo.MdiParent = this;
            fundo.Show();
        }

        private void InserirSrangria(object sender, EventArgs e)
        {
            Sangria sangria = new Sangria();
            sangria.MdiParent = this;
            sangria.Show();

        }

        private void cadastrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarEmpresa cadEmpresa = new CadastrarEmpresa();
            cadEmpresa.MdiParent = this;
            cadEmpresa.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastrarColaborador c  = new CadastrarColaborador();
            c.MdiParent = this;
            c.Show();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CadastrarLogin c = new CadastrarLogin();
            c.MdiParent = this;
            c.Show();

        }
    }

    
}
