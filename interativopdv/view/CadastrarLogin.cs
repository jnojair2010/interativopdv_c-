using interativopdv.model;
using interativopdv.server;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class CadastrarLogin : Form
    {
        public CadastrarLogin()
        {
            InitializeComponent();
        }

        private void btnSalvarLogin_Click(object sender, EventArgs e)
        {

            ServiceLogin serviceLogin = new ServiceLogin();

            ColaboradorModel colaborador = new ColaboradorModel();

            colaborador.Login.Login = txtRegristryLogin.Text.Trim();
            colaborador.Login.Password = txtRegistryPassword.Text.Trim();
            colaborador.Cpf = txtCpf.Text.Trim();


            serviceLogin.insertLogin(colaborador);
        }
    }
}
