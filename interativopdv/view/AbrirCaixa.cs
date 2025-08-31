using interativopdv.server;
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
    public partial class AbrirCaixa : Form
    {
        UsuarioSystema userSystem = new UsuarioSystema();
        public AbrirCaixa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtPasswordCx.Text;

            if (password == userSystem.PasswordUser())
            {
                FundoTrocoInicial fundoTroco = new FundoTrocoInicial();
                fundoTroco.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
        }

        private void txtPasswordCx_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
