using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class PessoaModel
    {
        private string name;
        private string sobreName;
        private string cpf;
        private string dataNascimento;
        private string email;

        private EnderecoModel endereco = new EnderecoModel();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SobreName
        {
            get { return sobreName; }
            set { sobreName = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }

        }
        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public EnderecoModel Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
