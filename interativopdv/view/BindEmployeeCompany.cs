using interativopdv.model;
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
    public partial class BindEmployeeCompany : Form
    {

        public BindEmployeeCompany()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void BindEmployeeCompany_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // permissoes
            bool registryPricePurchse = cBRegistryPricePurchace.Checked;
            bool viewPricePurchase = cBViewPricePurchase.Checked;
            bool menuEnterprise = cBMenuEmpresa.Checked;
            bool menuEmployee = cBMenuColaborador.Checked;
            bool menuSuplier = cBMenuFornecedor.Checked;
            bool menuProducto = cBMenuProducto.Checked;
            bool menuBox = cBMenuCaixa.Checked;

            PermissoesUserSystem permission = new PermissoesUserSystem();

            permission.EnterComPrice = registryPricePurchse;
            permission.InputPricePurchase = viewPricePurchase;
            permission.MenuEmpresa = menuEnterprise;
            permission.MenuColaborador = menuEmployee;
            permission.MenuFornecedor = menuSuplier;
            permission.MenuProdutos = menuProducto;
            permission.MenuCaixa = menuBox;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getEmpreendimentos(object sender, EventArgs e)
        {
            CheckBox checkBoxEmpresa = new CheckBox();
            checkBoxEmpresa.Location = new System.Drawing.Point(20, 20);
            checkBoxEmpresa.Text = "AejBiju";

            grBoxVincular.Controls.Add(checkBoxEmpresa);
        }
    }
}
