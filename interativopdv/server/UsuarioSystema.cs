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

        public void SetUsuarioSystema(ColaboradorModel colaborador)
        {
            usuarioSystema.Name = colaborador.Name;
            usuarioSystema.SobreName = colaborador.SobreName;
            usuarioSystema.Cpf = colaborador.Cpf;
            usuarioSystema.Email = colaborador.Email;

        }

        public void SetEndereco(EnderecoModel endereco)
        {
            usuarioSystema.Endereco = endereco;
        }

        public void PermissionSystem(PermissionUserSystem p)
        {
            usuarioSystema.PermissoesColaborador = p;
        }

        public PermissionUserSystem GetPermissionSystem
        {
            get { return usuarioSystema.PermissoesColaborador; }
        }

        public EnderecoModel getEndereco
        {
            get { return usuarioSystema.Endereco; }
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
