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

namespace interativopdv
{
    public partial class Login : Form
    {
        // usuatio statito do system
        UsuarioSystema userSystem = new UsuarioSystema();

        public Login()
        {
            InitializeComponent();
        }

        int countErroLogin = 0;
        private ServiceLogin LgServer = new ServiceLogin();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void logar(object sender, EventArgs e)
        {
          

            string login = txtLogin.Text;
            string password = txtPassword.Text;

            isLogado();

            LoginModel modelLogin = new LoginModel();
            modelLogin.Login = /*login*/ "jnojair2010@gmail.com";
            modelLogin.Password = /*password*/ "Lwx5nk@Lwx5nk";
            LgServer.ServerLogar(modelLogin);

            

            if (userSystem.idLoginUser() > 0)
            {
                // MessageBox.Show(" dentro do form login o id é " + LgServer.GetColaboradorModel.Login.IdLogin);
                this.Close();

            }
            else
            {
                countErroLogin++;
                MessageBox.Show(" Login Incrreto contador ");

                if (countErroLogin == 3)
                {
                    Application.Exit();
                }
            }

                isLogado();

        }

        private void isLogado()
        {
            bool isLogado = userSystem.isLoginUser();

            if (isLogado != true)
            {
                //MessageBox.Show(" o usuario não está logado!" + userSystem.isLoginUser());
            }
            else
            {
               // MessageBox.Show(" o usuario  está logado e seu estado de login é: "+ userSystem.isLoginUser());
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
