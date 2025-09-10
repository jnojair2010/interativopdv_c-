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
    internal class ServeLogin
    {
        // para retira a linha abaixo
       // public ColaboradorModel colaboradorLogado = new ColaboradorModel();  

       // para fazer a conexção http em backAnd
        private LoginRequest requesteLogin = new LoginRequest();

        // usuatio statito do system
        UsuarioSystema userSystem = new UsuarioSystema();

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
                        lm.Password = reader.GetString("password");
                        lm.Userid = reader.GetInt32("userId");

                        //confirma que login correto confirmado com retorno de dado db login e password
                        lm.IsLogado = true;

                        userSystem.UserSystemLogin(lm);

                    }
                    gerColaboradorDao(lm.Userid);

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(" erro  " + e.Message);

            }
        }

        public void gerColaboradorDao(int id)
        {
            ServiceColaborador serviceColaborador = new ServiceColaborador();
            serviceColaborador.getDaoColaborador(id);
        }

    }
}
