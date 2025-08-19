using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class LoginModel
    {
        private string login;
        private string password;
        private bool isLogado = false;


        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsLogado
        {
            get { return isLogado; }
            set { isLogado = value; }
        }
    }
}
