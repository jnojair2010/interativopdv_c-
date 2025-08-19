using interativopdv.model;
using interativopdv.serverhttp.loginhttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.server
{
    internal class ServerLogin
    {

        public static ColaboradorModel colaboradorLogado = new ColaboradorModel();

        private LoginRequest requesteLogin = new LoginRequest();

        public LoginModel ServerLogar(LoginModel login)
        {
            colaboradorLogado.Login = login;


            return colaboradorLogado.Login;
        }

        public LoginModel IsToLogado()
        {
            return colaboradorLogado.Login;
        }
    }
}
