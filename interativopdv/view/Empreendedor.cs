using interativopdv.model;
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
    public partial class Empreendedor : Form
    {
        ServiceOwner serviceOwner = new ServiceOwner();
        public Empreendedor()
        {
            InitializeComponent();
        }

        private void btnSalvarEmpreendedor_Click(object sender, EventArgs e)
        {
            OwnerModel owner = new OwnerModel();

            owner.FirstName = txtNameEntrepreneur.Text;
            owner.LastName = txtSobreNameEntrepreneur.Text;
            owner.Cpf = txtCpf.Text;

            serviceOwner.insertOwner(owner);

            txtNameEntrepreneur.Clear();
            txtSobreNameEntrepreneur.Clear();
            txtCpf.Clear();

        }
    }
}
