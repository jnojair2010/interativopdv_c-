using interativopdv.dao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv.server
{
    internal class ServiceColaborador
    {
        UsuarioSystema userSystem = new UsuarioSystema();

        public void getDaoColaborador(int id)
        {

             ConexaoDb1 conexaoDb1 = new ConexaoDb1();
              bool conn = conexaoDb1.OpenConexao();

              try
              {
                  if (conn == true)
                  {
                      var command = new MySqlCommand("select u.idUser, u.firstName, u.lastName, u.email, u.cpf, l.idLogin, l.login, l.password, e.idEmployee, e.assignment, e.isActive from user" +
                          "  as u inner join login as l ON u.idUser = l.userId inner join employee as e ON u.idUser = e.idUser where u.idUser=@id; ", conexaoDb1.GetConnection());
                      command.Parameters.AddWithValue("@id", id);
                      var reader = command.ExecuteReader();

                      while (reader.Read())
                      {
                        userSystem.usu
                        MessageBox.Show(" o id na requisição do colaborador é: "+ reader.GetString("assignment"));

                      }

                  }

              }
              catch (Exception e)
              {
                  MessageBox.Show(" erro  " + e.Message);

              }
              
        }
    }
}
