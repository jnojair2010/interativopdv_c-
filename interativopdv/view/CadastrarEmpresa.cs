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
            string cnpj = txtCnpJEmterprise.Text;
            string cpfOwner = txtCpfOwner.Text;
            string nameEnyterprice = txtNameEnterprice.Text;
            string nameFantasy = txtNameFantasy.Text;

            EnderecoModel endereco = new EnderecoModel();

            endereco.Logradouro = txtLogradouro.Text;
            endereco.Numero = txtNumber.Text;
            endereco.Cep = txtCep.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Uf = txtEstado.Text;
            endereco.Complemento = txtComplemento.Text;

        }



        private void getOwner(object sender, EventArgs e)
        {
            OwnerModel owner = new OwnerModel();

            string cpf = txtCpfOwner.Text;

            owner.Cpf = cpf;

            if (cpf.Length>10)
            {
                owner = this.servicoOwner.getOwner(owner);

                if (owner.FirstName==null)
                {
                    MessageBox.Show("Cpf Invalido, Verifique e faça correções válida!");
                }
                else
                {
                    MessageBox.Show("o nome do empreeededor é: " + owner.FirstName);
                    ownerModel.Cpf = owner.Cpf;
                    SelectOwner selectOwner = new SelectOwner();
                    selectOwner.Show();

                }
            }
            else
            {
                MessageBox.Show("cpf Invalido");
                txtCpfOwner.Clear();
            }
            
        }
    }
}
