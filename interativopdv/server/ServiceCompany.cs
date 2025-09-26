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

     CompanyModel company = new CompanyModel();

        ConexaoDb1 conexaoDb1 = new ConexaoDb1();

        // retorna um empreendedor 
        public OwnerModel getDaoOwner(OwnerModel owner)
       {
            owner = serviceOwner.getOwner(owner);

           serviceOwner.setOwner(owner);
            return owner;
       }

        // inserir empresa no banco de dado
        public void insertCompany(CompanyModel c)
        {
            ConexaoDb1 conexaoDb1 = new ConexaoDb1();
            c.IdOwner = getOwnerId(c.Owner.Cpf);

            verificarCompany(c);

            try
            {
                if (this.company.IdComapany==0)
                {
                    MessageBox.Show($"o id da company igual a 0 é {this.company.IdComapany}");

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
                    MessageBox.Show($" companya {this.company.NameFantasia} já está cadastrado");
                    
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($" Entrou no mysqlException {e} ");
            }

            conexaoDb1.CloseConnect();
        }

        // verificar se a empresa está no banco de dado
        private void verificarCompany(CompanyModel c)
        {
            bool conn = conexaoDb1.OpenConexao();
            try
            {
                MessageBox.Show(" Entrou no try do verificarOwner!");

                if (conn)
                {
                    var command = new MySqlCommand("select * from company where cnpj =@cnpj;", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@cnpj", c.Cnpj);
                    var reader = command.ExecuteReader();

                    while (reader.Read() == true)
                    {
                        this.company.IdComapany = reader.GetInt32("idCompany");
                        this.company.IdOwner = reader.GetInt32("ownerId");
                        this.company.NameCompany = reader.GetString("name");
                        this.company.NameFantasia = reader.GetString("nameFantasia");
                        this.company.Cnpj = reader.GetString("cnpj");
                        this.company.Endereco.Logradouro = reader.GetString("logradouro");
                        this.company.Endereco.Numero = reader.GetString("number");
                        this.company.Endereco.Bairro = reader.GetString("bairro");
                        this.company.Endereco.Cidade = reader.GetString("cidade");
                        this.company.Endereco.Uf = reader.GetString("uf");
                        this.company.Endereco.Complemento = reader.GetString("complemento");
                        Console.WriteLine($" o nome da companhia é {reader.GetString("nameFantasia")}");
                        MessageBox.Show($" o id do company no while é {this.company.IdComapany}");
                    }
                    
                }
                else
                {
                    this.company.IdComapany = 0;
                    Console.WriteLine(" Entrou no erro do if variavel connecção");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($" Entrou no mysqlException {e} ");
            }

            conexaoDb1.CloseConnect();
        }

        public CompanyModel GetCompany(string cnpj)
        {
            CompanyModel company = new CompanyModel();

            bool conn = conexaoDb1.OpenConexao();

            var command = new MySqlCommand("select name, idCompany,ownerId, nameFantasia from company where cnpj=@cnpj", conexaoDb1.GetConnection());
            command.Parameters.AddWithValue("@cnpj", cnpj);
            var reader = command.ExecuteReader();

            while (reader.Read() == true) {
                company.IdComapany = reader.GetInt32("idCompany");
                company.IdOwner = reader.GetInt32("ownerId");
                company.NameCompany = reader.GetString("name");
                company.NameFantasia = reader.GetString("nameFantasia");
            }

            return company;
        }
        private int getOwnerId(string cpf)
        {
            bool conn = conexaoDb1.OpenConexao();
            int idOwner = 0;

            var command = new MySqlCommand("select idOwner from owner where cpf=@cpf", conexaoDb1.GetConnection());
            command.Parameters.AddWithValue("@cpf", cpf);
            var reader = command.ExecuteReader();

            while (reader.Read() == true)
            {
               idOwner = reader.GetInt32("idOwner");
            }
            conexaoDb1.CloseConnect();

            return idOwner;

        }

    }
}
