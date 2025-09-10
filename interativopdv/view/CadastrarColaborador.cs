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
    public partial class CadastrarColaborador : Form
    {
        public CadastrarColaborador()
        {
            InitializeComponent();

            ServiceAtividadesColabroador serviceAtividades = new ServiceAtividadesColabroador();
            List<FuncoesAtividadeColaboradorModel> listaFuncoes = new List<FuncoesAtividadeColaboradorModel>();

            listaFuncoes = serviceAtividades.Funcoes();

            int count = listaFuncoes.Count;


            for (int i = 0; i < count; i++)
            {
                cBoxSelectFuncao.Items.Add(listaFuncoes[i].Name);
            }




        }

        private void lblNomeColaborador_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarColaborador_Click(object sender, EventArgs e)
        {
            string nameColaborador = txtName.Text;
            string sobreNamecolaborado = txtSobrenomeColab.Text;
            string cpf = maskCpfEmployee.Text;

            string dataNasc = maskDataNasc.Text;
            string email = txtEmailColab.Text;
            string funcoa = cBoxSelectFuncao.Text;

            bool ativo = checkBox1.Checked;

            // endereco
            string endLogradouro = txtLogradouroColab.Text;
            string endNumber = txtEndNumbe.Text;
            string endCep = txtCepColab.Text;
            string endBairro = txtBairroColab.Text;
            string endCidade = txtCidadeColab.Text;
            string endEstado = txtEstadoColab.Text;
            string endComplemento = txtComplColab.Text;

            EnderecoModel endereco = new EnderecoModel();
            endereco.Logradouro = endLogradouro;
            endereco.Cep = endCep;
            endereco.Numero = endNumber;
            endereco.Bairro = endBairro;
            endereco.Cidade = endCidade;
            endereco.Uf = endEstado;
            endereco.Complemento = endComplemento;

        }

        private void cBoxSelectFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void getCompany(object sender, EventArgs e)
        {
           
        }
    }
}
