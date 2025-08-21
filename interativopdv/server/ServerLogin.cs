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


        public void ServerLogar(LoginModel login)
        {
           // colaboradorLogado.mLogin = login;

            LoginModel lm = new LoginModel();
            ConexaoDb1 conexaoDb1 = new ConexaoDb1();
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                if (conn == true)
                {
                    var command = new MySqlCommand("select * from login where login=@l and password=@p;", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@l", login.Login);
                    command.Parameters.AddWithValue("@p", login.Password);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lm.IdLogin = reader.GetInt32("idLogin");
                        lm.Login = reader.GetString("login");
                        lm.Password = reader.GetString("Password");

                        colaboradorLogado.Login = lm;

                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(" erro  " + e.Message);

            }
        }

        public LoginModel IsToLogado()
        {
            return colaboradorLogado.Login;
        }

        public ColaboradorModel GetColaboradorModel
        {
            get
            {
                return colaboradorLogado;
            }
        }
    }
}
