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
        public LoginModel getLoginDao(LoginModel login)
        {
            ConexaoDb1 conexaoDb1 = new ConexaoDb1();
            bool conn = conexaoDb1.OpenConexao();

            LoginModel mLoginModel = new LoginModel();  
            

            if (conn == true)
            {
                var command = new MySqlCommand("select * from login where login=@login and password=@password;", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@login", login.Login);
                command.Parameters.AddWithValue("@password", login.Password);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    mLoginModel.IdLogin = reader.GetInt32("idLogin");
                    mLoginModel.Login = reader.GetString("login");
                    mLoginModel.Password = reader.GetString("password");
                    mLoginModel.IsLogado = true;

                }

            }

            MessageBox.Show($" o ide no model : {mLoginModel.idLogin}");
            return mLoginModel;
        }
    }
}
