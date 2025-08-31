using interativopdv.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.server
{
    internal class UsuarioSystema
    {
        private static ColaboradorModel usuarioSystema = new ColaboradorModel();



        public void UserSystemLogin(LoginModel  l)
        {
            usuarioSystema.Login.IdLogin = l.IdLogin;
            usuarioSystema.Login.Login =l.Login;
            usuarioSystema.Login.Password =l.Password;
            usuarioSystema.Login.IsLogado =l.IsLogado;
            usuarioSystema.Login.Userid =l.Userid;


        }
        public ColaboradorModel GetUsuarioSystema()
        {
            return usuarioSystema;
        }
        public ColaboradorModel SetUsuarioSystema(ColaboradorModel colaborador)
        {
            usuarioSystema.Name = colaborador.Name;
            usuarioSystema.SobreName = colaborador.SobreName;
            usuarioSystema.Cpf = colaborador.Cpf;
            
        }

         public string LoginUser()
         {
            return usuarioSystema.Login.Login;
         }
         public string PasswordUser()
         {
            return usuarioSystema.Login.Password;
         }
        public int idLoginUser()
        {
            return usuarioSystema.Login.IdLogin;
        }
        public bool isLoginUser()
        {
            return usuarioSystema.Login.IsLogado;
        }
        public int UserId() {
            return usuarioSystema.Login.Userid;
        }


    }
}
