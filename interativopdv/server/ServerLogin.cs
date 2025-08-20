using interativopdv.dao;
using interativopdv.model;
using interativopdv.serverhttp.loginhttp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv.server
{
    internal class ServerLogin
    {

        public static ColaboradorModel colaboradorLogado = new ColaboradorModel();

        private LoginRequest requesteLogin = new LoginRequest();


        public LoginModel ServerLogar(LoginModel login)
        {
           // colaboradorLogado.mLogin = login;
            LoginModel ml = new LoginModel();
            colaboradorLogado.setLogin=ml.getLoginDao(login);

            MessageBox.Show($" o di do login é: {ml.IdLogin}");

            return colaboradorLogado.mLogin;
        }

        public LoginModel IsToLogado()
        {
            return colaboradorLogado.mLogin;
        }
    }
}
