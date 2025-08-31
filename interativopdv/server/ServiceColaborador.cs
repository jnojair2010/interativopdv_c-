using interativopdv.dao;
using interativopdv.model;
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

        ConexaoDb1 conexaoDb1 = new ConexaoDb1();
       

        public void getDaoColaborador(int id)
        {
            bool conn = conexaoDb1.OpenConexao();

            try
              {
                  if (conn == true)
                  {
                      var command = new MySqlCommand("select u.idUser, u.firstName, u.lastName, u.email, u.cpf, e.idEmployee, e.assignment," +
                          " e.isActive, a.idAddress, a.logradouro, a.number, a.bairro, a.cidade, a.uf, a.complemento" +
                          " from user as u  inner join employee as e ON u.idUser = e.idUser inner join address as a ON u.idUser = a.idUser where u.idUser=@id; ", conexaoDb1.GetConnection());
                      command.Parameters.AddWithValue("@id", id);
                      var reader = command.ExecuteReader();

                      while (reader.Read())
                      {
                        // enviar endereço para class static de colaborador o login não vai porque ja foi ao efetura o login no inicio.
                        EnderecoModel endereco = new EnderecoModel();

                        endereco.Id = reader.GetInt32("idAddress");
                        endereco.Logradouro = reader.GetString("logradouro");
                        endereco.Numero = reader.GetString("number");
                        endereco.Bairro = reader.GetString("bairro");
                        endereco.Cidade = reader.GetString("cidade");
                        endereco.Uf = reader.GetString("uf");
                        endereco.Complemento = reader.GetString("complemento");

                        userSystem.SetEndereco(endereco);

                        getDaoPermissionColaborador(reader.GetInt32("idEmployee"));

                       // MessageBox.Show(" o id od employee is: : "+ reader.GetInt32("idEmployee"));

                      }

                  }

              }
              catch (Exception e)
              {
                  MessageBox.Show(" erro  " + e.Message);

              }
              
        }

        public void getDaoPermissionColaborador(int idEmployee)
        {
            bool conn = conexaoDb1.OpenConexao();
            try
            {
                if (conn == true)
                {
                    var command = new MySqlCommand("select * from permission where employeeId=@id", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@id", idEmployee);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PermissoesUserSystem permission = new PermissoesUserSystem();
                        permission.EnterComPrice = reader.GetBoolean("enterComPrice");
                        permission.InputPricePurchase = reader.GetBoolean("inputPricePurchase");
                        permission.MenuEmpresa = reader.GetBoolean("menuEmpresa");
                        permission.MenuColaborador = reader.GetBoolean("menuColaborador");
                        permission.MenuFornecedor = reader.GetBoolean("menuFornecedor");
                        permission.MenuProdutos = reader.GetBoolean("menuProducto");
                        permission.MenuCaixa = reader.GetBoolean("menuCaixa");
                        userSystem.PermissionSystem(permission);

                       // MessageBox.Show(" a permissao do menu caixa é : " + reader.GetBoolean("inputPricePurchase"));
                    }
                        
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(" erro em buscar permissoes " + e.Message);
            }
        }
    }
}
