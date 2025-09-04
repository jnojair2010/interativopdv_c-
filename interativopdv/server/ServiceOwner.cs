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
  
    internal class ServiceOwner
    {

       ConexaoDb1 conexaoDb1 = new ConexaoDb1();

        OwnerModel empreendedor = new OwnerModel();
        public void insertOwner(OwnerModel owner)
        {
            
            bool conn = conexaoDb1.OpenConexao();

            this.empreendedor.FirstName = owner.FirstName;
            this.empreendedor.LastName = owner.LastName;
            this.empreendedor.Cpf = owner.Cpf;


         verificarOwner(owner);


              if (empreendedor.IdOwner == 0)
              {
                  try
                  {
                      if (conn == true)
                      {
                          var command = new MySqlCommand("insert into owner (firstName, lastName, cpf) values ( @firstName, @lastName, @cpf );", conexaoDb1.GetConnection());
                          command.Parameters.AddWithValue("@firstName", owner.FirstName);
                          command.Parameters.AddWithValue("@lastName", owner.LastName);
                          command.Parameters.AddWithValue("@cpf", owner.Cpf);
                           command.ExecuteNonQuery();



                          MessageBox.Show(" Inserido com sucesso!");
                      }
                      else
                      {
                          Console.WriteLine(" conexção não foi bem sucedida!");

                          MessageBox.Show(" Erro ao Inserir");
                      }


                  }

                  catch (Exception ex)
                  {
                      Console.WriteLine(" Error" + ex.Message);

                  }
              }
              if(empreendedor.IdOwner>0)
              {
                  MessageBox.Show(" Usuario já tem Cadastro!");
              }

        }
        public OwnerModel getOwner(OwnerModel o)
        {
            ConexaoDb1 conexaoDb1 = new ConexaoDb1();
            bool conn = conexaoDb1.OpenConexao();

            OwnerModel owner = new OwnerModel();

            verificarOwner(o);

            return empreendedor;

        }


        private void verificarOwner(OwnerModel empreendedor)
        {
            OwnerModel owner = new OwnerModel();
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                Console.WriteLine(" Entrou no try do verificarOwner!");

                if (conn == true)
                {
                    var command = new MySqlCommand("select * from owner where cpf=@cpf;", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@cpf", empreendedor.Cpf);
                    var reader = command.ExecuteReader();

                    Console.WriteLine(" Entrou no if conn do verificarOwner!");

                    if (reader.Read() ==true)
                   {
                       this.empreendedor.IdOwner = reader.GetInt32("idOwner");
                        this.empreendedor.FirstName = reader.GetString("firstName");
                        this.empreendedor.LastName = reader.GetString("lastName");


                        Console.WriteLine(" Entrou no if reader.Read() do verificarOwner! e o id od owner é: "+ reader.GetInt32("idOwner"));

                   }
                   else
                   {
                        Console.WriteLine(" Entrou no  else do if reader.Read() do verificarOwner!");
                        this.empreendedor.IdOwner = 0;
                   }
                }
                else
                {
                    Console.WriteLine(" Entrou no  else do if conn do verificarOwner!");
                    MessageBox.Show(" Entrou no if do conn ");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(" erro  " + e.Message);

            }
            conexaoDb1.CloseConnect();

        }
    }
}
