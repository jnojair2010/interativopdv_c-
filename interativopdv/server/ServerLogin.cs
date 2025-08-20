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
            colaboradorLogado.Login = login;
            ConexaoDb1 conexaoDb1 = new ConexaoDb1();
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                if (conn == true)
                {
                    var command = new MySqlCommand("select * from login;", conexaoDb1.GetConnection());
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MessageBox.Show($"id => {reader["idLogin"]} => login {reader["login"]} => senha {reader["password"]}");
                    }

                }
            }
            catch( Exception e)
            {
                MessageBox.Show(" erro  "+ e.Message);

            }

            
           

            return colaboradorLogado.Login;
        }

        public LoginModel IsToLogado()
        {
            return colaboradorLogado.Login;
        }
    }
}
