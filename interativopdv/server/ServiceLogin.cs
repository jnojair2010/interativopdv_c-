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
    internal class ServiceLogin
    {


       // para fazer a conexção http em backAnd
        private LoginRequest requesteLogin = new LoginRequest();
        ConexaoDb1 conexaoDb1 = new ConexaoDb1();

        // usuatio statito do system
        UsuarioSystema userSystem = new UsuarioSystema();

        public void ServerLogar(LoginModel login)
        {
           // colaboradorLogado.mLogin = login;

            LoginModel lm = new LoginModel();
            
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
            conexaoDb1.CloseConnect();
        }
        public void gerColaboradorDao(int id)
        {
            ServiceColaborador serviceColaborador = new ServiceColaborador();
            serviceColaborador.getDaoColaborador(id);
        }

        public void insertLogin(ColaboradorModel colaborador)
        {
            colaborador.IdUser = selectColaborador(colaborador);

             try
              {
                  var command = new MySqlCommand("insert into login (login, password, userId) values (@login, @password, @userId)", conexaoDb1.GetConnection());
                  command.Parameters.AddWithValue("@login", colaborador.Login.Login);
                  command.Parameters.AddWithValue("@password", colaborador.Login.Password);
                  command.Parameters.AddWithValue("@userId", colaborador.IdUser);

                  command.ExecuteNonQuery();

                  MessageBox.Show("Login Realizado com sucesso!");
              }
              catch (Exception e)
              {

              }
              conexaoDb1.CloseConnect();
        }

        private int selectColaborador(ColaboradorModel colaborador)
        {
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                var command = new MySqlCommand("select idUser from user where cpf=@cpf;", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@cpf", colaborador.Cpf);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    colaborador.IdUser = reader.GetInt32("idUser");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($" erro sql {e.Message}");
            }
            conexaoDb1.CloseConnect();

            
            return colaborador.IdUser;
        }

    }
}
