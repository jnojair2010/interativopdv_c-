using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class CompanyModel
    {
        private int idComapany;
        private string nameCompany;
        private string nameFantasia;
        private string cnpj;
        private int idOwner;

        private   EnderecoModel endereco = new EnderecoModel();

        public int IdComapany
        {
            get { return idComapany; }
            set { idComapany = value; }
        }
        public string NameCompany
        {
            get { return nameCompany; }
            set { nameCompany = value; }
        }
        public string NameFantasia
        {
            get { return nameFantasia; }
            set { nameFantasia = value; }
        }
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public int IdOwner
        {
            get { return idOwner; }
            set { idOwner = value; }
        }
        public EnderecoModel Endereco
        {   get { return endereco; }
            set {  endereco = value; }
        }
    }
}
