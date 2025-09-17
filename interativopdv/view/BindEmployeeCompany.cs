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
    public partial class BindEmployeeCompany : Form
    {
        CompanyModel company = new CompanyModel();
        ColaboradorModel colaborador = new ColaboradorModel();
        ServiceCompany serviceCompany = new ServiceCompany();
        ServiceColaborador  serviceColaborador = new ServiceColaborador();
        CheckBox checkBoxEmpresa = new CheckBox();


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
            bool registryPricePurchse = registryPricePurchace.Checked;
            bool viewPricePurchase = this.viewPricePurchase.Checked;
            bool menuEnterprise = cBMenuEmpresa.Checked;
            bool menuEmployee = cBMenuColaborador.Checked;
            bool menuSuplier = cBMenuFornecedor.Checked;
            bool menuProducto = cBMenuProducto.Checked;
            bool menuBox = cBMenuCaixa.Checked;

            PermissionUserSystem permission = new PermissionUserSystem();

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
            string cnpj = maskCnpj.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(",", "").Trim();
            company = serviceCompany.GetCompany(cnpj);

            
            checkBoxEmpresa.Location = new System.Drawing.Point(20, 20);
            checkBoxEmpresa.Text = company.NameFantasia;

            checkBoxEmpresa.Click += new EventHandler(confirmCheckedEmpresa);

            grBoxVincular.Height = 50;

            grBoxVincular.Controls.Add(checkBoxEmpresa);
        }

        private void toPresent(object sender, EventArgs e)
        {
            string cpf = mask_cpf.Text.Replace(".", "").Replace(",", "").Replace("-", "").Trim();

            ServiceColaborador service = new ServiceColaborador();

            colaborador = service.getColaborador(cpf);

            if(colaborador.Id == 0)
            {
                MessageBox.Show("Cpf Invalido");
            }
            else
            {
                MessageBox.Show($"Colaborador:   {colaborador.Name.ToUpper()} {colaborador.SobreName.ToUpper()}");
            }

        }

        private void confirmCheckedEmpresa(object sender, EventArgs e)
        {

            if(checkBoxEmpresa.Checked==true)
            {
                MessageBox.Show($"O Colaborador {colaborador.Name.ToUpper()} {colaborador.SobreName.ToUpper()} passa a operar na empresa {company.NameFantasia.ToUpper()}");

                serviceColaborador.verificarBindEmployeeCompany(colaborador.Id, company.IdComapany);

            }
            else
            {
                serviceColaborador.UnBindingEmployeeCompany(colaborador.Id, company.IdComapany);
                MessageBox.Show($"O colaborador {colaborador.Name.ToUpper()} {colaborador.SobreName.ToUpper()} deixa de Operar na empresa {company.NameFantasia.ToUpper()} ");
            }

            
        }

        private void maskCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void chechedViewPricePurchase(object sender, EventArgs e)
        {

        }

        private void checkedRegistrPricePurchase(object sender, EventArgs e)
        {

        }
    }
}
