using interativopdv.server;
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

namespace interativopdv.model
{
    public partial class CadastrarEmpresa : Form
    {
        ServiceOwner servicoOwner = new ServiceOwner();

        OwnerModel ownerModel = new OwnerModel();

        ServiceCompany serviceCompany = new ServiceCompany();
        public CadastrarEmpresa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarEmpresa_Click(object sender, EventArgs e)
        {
   
            CompanyModel companyModel = new CompanyModel();
            EnderecoModel endereco = new EnderecoModel();

            companyModel.Cnpj= txtCnpJEmterprise.Text.Trim();
            companyModel.NameFantasia = txtNameFantasy.Text.Trim();
            companyModel.NameCompany = txtNameEnterprice.Text.Trim();

            endereco.Logradouro = txtLogradouro.Text.Trim();
            endereco.Numero = txtNumber.Text.Trim();
            endereco.Cep = txtCep.Text.Trim();
            endereco.Bairro = txtBairro.Text.Trim();
            endereco.Cidade = txtCidade.Text.Trim();
            endereco.Uf = txtEstado.Text.Trim();
            endereco.Complemento = txtComplemento.Text.Trim();

            companyModel.Endereco = endereco;

            serviceCompany.insertCompany(companyModel);

        }



        private void getOwner(object sender, EventArgs e)
        {
            OwnerModel owner = new OwnerModel();

            string cpf = txtCpfOwner.Text.Trim();

            owner.Cpf = cpf;

            if (cpf.Length>10)
            {
                serviceCompany.getDaoOwner(owner);

                owner = serviceCompany.getOwner();

                
                if (owner.IdOwner>0)
                {
                    SelectOwner select = new SelectOwner();
                    select.Show();
                }
                else
                {
                    MessageBox.Show("Não tem cadastro para esse Cpf:");
                }


            }
            else
            {
                MessageBox.Show("cpf In:");
                txtCpfOwner.Clear();
            }
            
        }
    }
}
