using interativopdv.dao;
using interativopdv.model;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv.server
{
    
    
    internal class ServiceCompany
    {
        OwnerModel owner = new OwnerModel();

        // objeto ServiceOwner que contem um owner instaciado como estatico
       ServiceOwner serviceOwner = new ServiceOwner();

       private static CompanyModel company = new CompanyModel();

        ConexaoDb1 conexaoDb1 = new ConexaoDb1();

        // retorna um empreendedor 
        public OwnerModel getDaoOwner(OwnerModel owner)
       {
            owner = serviceOwner.getOwner(owner);

           serviceOwner.setOwner(owner);
            return owner;
       }

   
 

        //retorna o nome completo do empreendedor
        public string getNameAndSobreName()
        {
            company.IdOwner = owner.IdOwner;
            return owner.FirstName + " " + owner.LastName;
        }

        // inserir empresa no banco de dado
        public void insertCompany(CompanyModel c)
        {
            ConexaoDb1 conexaoDb1 = new ConexaoDb1();
            c.IdOwner = company.IdOwner;

            bool isExist =  verificarCompany(c);
            Console.WriteLine($" a existencia no insertCompany é {isExist}");

            try
            {
                if (isExist == false)
                {
                    var command = new MySqlCommand("insert into company (name, cnpj, ownerId, nameFantasia, logradouro, number, bairro, cidade, uf, complemento)" +
                        " values ( @name, @cnpj, @ownerId, @nameFantasia, @logradouro, @number, @bairro, @cidade, @uf, @complemento);", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@name", c.NameCompany);
                    command.Parameters.AddWithValue("@cnpj", c.Cnpj);
                    command.Parameters.AddWithValue("@nameFantasia", c.NameFantasia);
                    command.Parameters.AddWithValue("@logradouro", c.Endereco.Logradouro);
                    command.Parameters.AddWithValue("@number", c.Endereco.Numero);
                    command.Parameters.AddWithValue("@bairro", c.Endereco.Bairro);
                    command.Parameters.AddWithValue("@cidade", c.Endereco.Cidade);
                    command.Parameters.AddWithValue("@uf", c.Endereco.Uf);
                    command.Parameters.AddWithValue("@complemento", c.Endereco.Complemento);
                    command.Parameters.AddWithValue("@ownerId", c.IdOwner);

                    command.ExecuteNonQuery();

                    MessageBox.Show(" Inserido com sucesso!");

                }
                else
                {
                    MessageBox.Show(" Erro ao Inserir");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($" Entrou no mysqlException {e} ");
            }

            conexaoDb1.CloseConnect();
        }

        // verificar se a empresa está no banco de dado
        private bool verificarCompany(CompanyModel c)
        {
            bool isExist = false;

            bool conn = conexaoDb1.OpenConexao();

            try
            {
                Console.WriteLine(" Entrou no try do verificarOwner!");

                if (conn)
                {
                    var command = new MySqlCommand("select idCompany from company where ownerId =@cnpj;", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@idOwner", c.Cnpj);
                    var reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        Console.WriteLine(" Entrou no if do reader igual a true atribui isExist em true campany exist!");
                        isExist = true;
                    }
                    else
                    {
                        Console.WriteLine(" Entrou no else do reader igual a false atribui isExist em true campany exist!");
                        isExist = false;
                    }

                }
                else
                {
                    Console.WriteLine(" Entrou no erro do if variavel connecção");

                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine($" Entrou no mysqlException {e} ");
            }

            conexaoDb1.CloseConnect();
            return isExist;
        }

    }
}
