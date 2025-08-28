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
        private ColaboradorModel colaborador = new ColaboradorModel();
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
            EnderecoModel endereco = new EnderecoModel();
            endereco.Bairro = txtBairro.Text;
            endereco.Cep = txtCep.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Complemento = txtComplemento.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Uf = txtEstado.Text;

            colaborador.Endereco = endereco;
            colaborador.Name = txtName.Text;
            colaborador.Cpf = txtCpf.Text;
            colaborador.SobreName = txtSobreName.Text;
            colaborador.Email = txtEmail.Text;
           // colaborador.DataNascimento = txtDataNasc.Text;
            colaborador.IsActive = cboxIsActive.Checked;

            string cnpjLoja = txtCpf.Text;

            MessageBox.Show(" a atividade selecionada é "+cBoxSelectFuncao.Text+" está ativo?"+cboxIsActive.Checked);
        }
    }
}
