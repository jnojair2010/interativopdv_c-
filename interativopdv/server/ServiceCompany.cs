using interativopdv.model;
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

     private static  OwnerModel owner = new OwnerModel();

       ServiceOwner serviceOwner = new ServiceOwner();

       private static CompanyModel company = new CompanyModel();


       public void getDaoOwner(OwnerModel o)
       {
            owner = serviceOwner.getOwner(o);
       }

        public OwnerModel getOwner()
        {
            return owner;
        } 

        public string getNameAndSobreName()
        {
            company.IdOwner = owner.IdOwner;
            return owner.FirstName + " " + owner.LastName;
        }

        public void insertCompany(CompanyModel c)
        {
            c.IdOwner = company.IdOwner;

            MessageBox.Show("O nome da Empresa é: " + c.NameCompany + " nome fantasia é: " + c.NameFantasia+"\n"+" o cnpj é: "+c.Cnpj+" o id Owner é: "+c.IdOwner+"\n \n"+ "Logradroudo: "+c.Endereco.Logradouro+"" +
                "numero: "+c.Endereco.Numero+" cep: "+c.Endereco.Cep+" bairro: "+c.Endereco.Bairro+" cidade: "+c.Endereco.Cidade+" Estado: "+c.Endereco.Uf+" complemento: "+c.Endereco.Complemento);
        }

    }
}
