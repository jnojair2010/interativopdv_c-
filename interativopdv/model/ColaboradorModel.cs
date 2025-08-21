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
        private bool stado;

        private LoginModel login = new LoginModel();    

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
        public bool Stado  
        { 
            get { return stado; }
            set { stado = value; }
        }
        public void setLogin(LoginModel l)
        {
            login.Login = l.Login;
            login.Password = l.Password;

        }

    }
}
