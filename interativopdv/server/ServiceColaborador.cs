using interativopdv.dao;
using interativopdv.model;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
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
                        PermissionUserSystem permission = new PermissionUserSystem();
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

        public ColaboradorModel getColaborador(string cpf)
        {
            ColaboradorModel colaborador = new ColaboradorModel();
            
            bool conn = conexaoDb1.OpenConexao();
            try
            {
                var command = new MySqlCommand("select u.firstName, u.lastName, u.cpf, u.idUser, e.idEmployee, e.assignment," +
                " e.isActive from user as u inner join employee as e ON u.idUser = e.idUser where u.cpf =@cpf", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@cpf", cpf);
                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    colaborador.Name = reader.GetString("firstName");
                    colaborador.SobreName = reader.GetString("lastName");
                    colaborador.Cpf = reader.GetString("cpf");
                    colaborador.IdUser = reader.GetInt32("idUser");
                    colaborador.Id = reader.GetInt32("idEmployee");
                    colaborador.Status = reader.GetBoolean("isActive");
                    colaborador.Funcao = reader.GetString("assignment");
                }
            }
            catch (Exception e) { 

            }

            return colaborador;
        }

        public void InsertBindEmployeeCompany(int idEmployee, int idCompany)
        {

           bool conn = conexaoDb1.OpenConexao();

                try
                {
                    var command = new MySqlCommand("insert into employee_company (employeeId, company_id, isBind) values (@idEmployee, @idCompany, @isBind)", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@idEmployee", idEmployee);
                    command.Parameters.AddWithValue("@idCompany", idCompany);
                    command.Parameters.AddWithValue("@isBind", true);

                    command.ExecuteNonQuery();

                    MessageBox.Show(" Vinculação realizzado com sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show($" erro sql no bindempl ");
                }

        }
        public void UnBindingEmployeeCompany(int idEmployee, int idCompany)
        {
            bool conn = conexaoDb1.OpenConexao();
            try
            {
                var command = new MySqlCommand("UPDATE employee_company SET isBind = @isBind where employeeId=@idEmployee AND company_id=@idCompany", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@idEmployee", idEmployee);
                command.Parameters.AddWithValue("@idCompany", idCompany);
                command.Parameters.AddWithValue("@isBind", false);

                command.ExecuteNonQuery();

                MessageBox.Show(" Desvinculação bem sucedido!");
            }
            catch (Exception e)
            {
                MessageBox.Show($" erro sql "+e.Message);
            }
            conexaoDb1.CloseConnect();

        }

        private void BindingEmployeeCompany(int idEmployee, int idCompany)
        {
            bool conn = conexaoDb1.OpenConexao();
            try
            {
                var command = new MySqlCommand("UPDATE employee_company SET isBind = @isBind where employeeId=@idEmployee AND company_id=@idCompany", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@idEmployee", idEmployee);
                command.Parameters.AddWithValue("@idCompany", idCompany);
                command.Parameters.AddWithValue("@isBind", true);

                command.ExecuteNonQuery();

                MessageBox.Show(" Vinculação sucedido!");
            }
            catch (Exception e)
            {
                MessageBox.Show($" erro sql " + e.Message);
            }
            conexaoDb1.CloseConnect();
        }

        public void verificarBindEmployeeCompany(int idEmployee, int idCompany)
        {
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                var command = new MySqlCommand("select * from employee_company where employeeId =@idEmployee and company_id=@idCompany", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@idEmployee", idEmployee);
                command.Parameters.AddWithValue("@idCompany", idCompany);

                var reader = command.ExecuteReader();

                if(reader.Read()== true)
                {
                    if (reader.GetBoolean("isBind") == false)
                    {
                        BindingEmployeeCompany(idEmployee, idCompany);
                    }
                }
                else
                {
                    InsertBindEmployeeCompany(idEmployee, idCompany);
                }
            
            }
            catch (Exception e)
            {
                MessageBox.Show($" erro sql verificação ");
            }

            conexaoDb1.CloseConnect();

        }

        public void insertUser(ColaboradorModel model)
        {
            ColaboradorModel colaboradorModel = new ColaboradorModel();
            bool conn = conexaoDb1.OpenConexao();
            model.IdUser = verificarUserColaborador(model);
            model.Id = verificarColaborador(model);

            if ( model.IdUser== 0){
                try
                {
                    var command = new MySqlCommand("insert into user (firstName, lastName,email, cpf, dataNasc) values (@firstName, @lastName, @email, @cpf, STR_TO_DATE(@dataNasc,'%d/%m/%Y'))", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@firstName", model.Name);
                    command.Parameters.AddWithValue("@lastName", model.SobreName);
                    command.Parameters.AddWithValue("@email", model.Email);
                    command.Parameters.AddWithValue("@cpf", model.Cpf);
                    command.Parameters.AddWithValue("@dataNasc", model.DataNascimento);
                    command.ExecuteNonQuery();

                    

                    colaboradorModel.IdUser = verificarUserColaborador(model);
                    model.IdUser = colaboradorModel.IdUser;

                    insertEmployee(model);
                    model.Id = verificarColaborador(model);
                    insertPermissionInRegistryEmployee(model);
                    insertAddress(model);
                    

                }
                catch(Exception e) {
                    Console.WriteLine($" Erro sql  insert user {e.Message}");
                }
            }


        }

        private void insertEmployee(ColaboradorModel model)
        {
            ColaboradorModel colaboradorModel = new ColaboradorModel();
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                var command = new MySqlCommand("insert into employee (assignment, isActive, idUser) values (@assignment, @isActive, @idUser) ", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@assignment", model.Funcao);
                command.Parameters.AddWithValue("@isActive", model.Status);
                command.Parameters.AddWithValue("@idUser", model.IdUser);
                command.ExecuteNonQuery();

                MessageBox.Show(" Colaborador Inserido com sucesso!");
            }
            catch(Exception e) {

                Console.WriteLine(" Erro  insert employee"+e.Message);
            }
            conexaoDb1.CloseConnect();
        }
        private void insertAddress(ColaboradorModel model)
        {
            bool conn = conexaoDb1.OpenConexao();

            try
            {

                var command = new MySqlCommand("insert into address (logradouro,number, bairro, cidade,uf,complemento,idUser, cep)" +
                    " values (@logradouro,@number, @bairro, @cidade, @uf, @complemento, @idUser, @cep) ", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@logradouro", model.Endereco.Logradouro);
                command.Parameters.AddWithValue("@number", model.Endereco.Numero);
                command.Parameters.AddWithValue("@bairro", model.Endereco.Bairro);
                command.Parameters.AddWithValue("@cidade", model.Endereco.Cidade);
                command.Parameters.AddWithValue("@uf", model.Endereco.Uf);
                command.Parameters.AddWithValue("@complemento", model.Endereco.Complemento);
                command.Parameters.AddWithValue("@idUser", model.IdUser);
                command.Parameters.AddWithValue("@cep", model.Endereco.Cep);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(" Erro  insert employee" + e.Message);
            }

            conexaoDb1.CloseConnect();
        }
        private void insertPermissionInRegistryEmployee(ColaboradorModel model)
        {
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                var command = new MySqlCommand("insert into permission (enterComPrice, inputPricePurchase, menuEmpresa, menuColaborador, menuFornecedor, menuProducto, menuCaixa, employeeId)" +
                    " values (@enterComPrice, @inputPricePurchase, @menuEmpresa, @menuColaborador, @menuFornecedor, @menuProducto, @menuCaixa, @employeeId) ", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@enterComPrice", model.Permission.EnterComPrice);
                command.Parameters.AddWithValue("@inputPricePurchase", model.Permission.InputPricePurchase);
                command.Parameters.AddWithValue("@menuEmpresa", model.Permission.MenuEmpresa);
                command.Parameters.AddWithValue("@menuColaborador", model.Permission.MenuColaborador);
                command.Parameters.AddWithValue("@menuFornecedor", model.Permission.MenuFornecedor);
                command.Parameters.AddWithValue("@menuProducto", model.Permission.MenuProdutos);
                command.Parameters.AddWithValue("@menuCaixa", model.Permission.MenuCaixa);
                command.Parameters.AddWithValue("@employeeId", model.Id);

                command.ExecuteNonQuery();

            }
            catch(Exception e) {
                Console.WriteLine(e.Message); 
            }
            conexaoDb1.CloseConnect();
        }


        // retornar o id do usuario se existir usuario
        private int verificarUserColaborador(ColaboradorModel model)
        {
            ColaboradorModel colaboradorModel = new ColaboradorModel();
            bool conn = conexaoDb1.OpenConexao();
           
                try
                {
                    var command = new MySqlCommand("select * from user where cpf=@cpf ", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@cpf", model.Cpf);

                    var reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {

                        colaboradorModel.IdUser = reader.GetInt32("idUser");
                        Console.WriteLine($" o reader no verificar user colaborador {reader.Read()} e seu idUser é {colaboradorModel.IdUser} e id employee é {colaboradorModel.Id}");

                         conexaoDb1.CloseConnect();
                         return colaboradorModel.IdUser;
                    }
                    else
                    {
                        Console.WriteLine($" reader {reader.Read()}");

                        conexaoDb1.CloseConnect();
                        return 0;
                    }
                
                }
                catch (Exception e)
                {
                    Console.WriteLine($" Erro sql {e.Message}");

                    conexaoDb1.CloseConnect();
                    return 0;
                }

            

        }

        //verifica o id do colaborador / employee se existir 
        private int verificarColaborador(ColaboradorModel model)
        {
            ColaboradorModel colaboradorModel = new ColaboradorModel();
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                var command = new MySqlCommand("select * from employee where idUser=@idUser ", conexaoDb1.GetConnection());
                command.Parameters.AddWithValue("@idUser",model.IdUser);

                var reader = command.ExecuteReader();

                if (reader.Read() == true)
                {

                    colaboradorModel.Id = reader.GetInt32("idEmployee");

                    Console.WriteLine($" o reader no verificar user colaborador {reader.Read()} e seu idUser é {colaboradorModel.IdUser} e id employee é {colaboradorModel.Id}");

                    conexaoDb1.CloseConnect();
                    return colaboradorModel.Id;
                }
                else
                {
                    Console.WriteLine($" reader {reader.Read()}");
                    conexaoDb1.CloseConnect();
                    return 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($" erro sql verificação ");
                conexaoDb1.CloseConnect();
                return 0;
            }
        }


    }
}
