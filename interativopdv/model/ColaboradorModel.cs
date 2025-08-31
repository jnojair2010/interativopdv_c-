using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class ColaboradorModel:PessoaModel
    {
        private int id;
        private string funcao;
        private bool status;

        private LoginModel login = new LoginModel();  
        
        private PermissoesUserSystem permissoesColaborador = new PermissoesUserSystem();

        private EnderecoModel endereco = new EnderecoModel();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }
        public bool Status  
        { 
            get { return status; }
            set { status = value; }
        }
        public LoginModel Login
        {
            get { return login; }
            set { login = value; }
        }
        public PermissoesUserSystem PermissoesColaborador
        {
            get { return permissoesColaborador;}
            set {  permissoesColaborador= value; }
        }
        public EnderecoModel Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

    }
}
