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
        ServiceColaborador serviceColaborador = new ServiceColaborador();
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

            ColaboradorModel colaborador = new ColaboradorModel();

            colaborador.Name = txtName.Text.Trim();
            colaborador.SobreName = txtSobrenomeColab.Text.Trim();
            colaborador.Cpf = maskCpfEmployee.Text.Trim().Replace(",","").Replace("-","").Replace(".","");
            colaborador.DataNascimento = maskDataNasc.Text.Trim();

            colaborador.DataNascimento = maskDataNasc.Text.Trim();
            colaborador.Email = txtEmailColab.Text.Trim();
            colaborador.Funcao = cBoxSelectFuncao.Text.Trim();

           colaborador.Status = checkBox1.Checked;

            switch (colaborador.Funcao)
            {
                case "Administrador":
                    colaborador.Permission.setAdministrador();
                    break;
                case "Atendente":
                    colaborador.Permission.setAtendente();
                    break;
                case "Caixa":
                    colaborador.Permission.setCaixa();
                    break;
                case "Gerente":
                    colaborador.Permission.setGerente();
                    break;
                case "Desenvolvedor":
                    colaborador.Permission.setDesenvolvedor();
                    break;
                default:
                    break;

            }

            // endereco
            colaborador.Endereco.Logradouro = txtLogradouroColab.Text.Trim();
            colaborador.Endereco.Numero = txtEndNumbe.Text.Trim();
            colaborador.Endereco.Cep = maskCpfEmployee.Text.Trim().Replace(",","").Replace(".","").Replace("-","");
            colaborador.Endereco.Bairro= txtBairroColab.Text.Trim();
            colaborador.Endereco.Cidade = txtCidadeColab.Text.Trim();
            colaborador.Endereco.Uf = txtEstadoColab.Text.Trim();
            colaborador.Endereco.Complemento = txtComplColab.Text.Trim();

            MessageBox.Show($" a função do colaborador cadastrado é {colaborador.Funcao}");

            serviceColaborador.insertUser(colaborador);
            this.Close();
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
