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
        private bool isActive;
       

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
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        } 

        public LoginModel Login
        {
            get { return login; }
            set { login = value; }
        }


    }
}
