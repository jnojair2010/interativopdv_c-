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
        private int idUser;
        private string name;
        private string sobreName;
        private string cpf;
        private string email;
        private string dataNascimento;

        private EnderecoModel endereco = new EnderecoModel();

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
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

        public string Email
        {
            get { return email;  }
            set { email = value; }
        }

        public EnderecoModel Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}
