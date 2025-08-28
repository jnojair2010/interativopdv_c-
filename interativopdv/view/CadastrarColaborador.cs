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

        }
    }
}
