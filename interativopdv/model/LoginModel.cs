using interativopdv.dao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv.model
{
    internal class LoginModel
    {
        private int idLogin;
        private string login;
        private string password;
        private bool isLogado = false;


        public int IdLogin
        {
            get { return idLogin; }
            set { idLogin = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsLogado
        {
            get { return isLogado; }
            set { isLogado = value; }
        }

    }
}
