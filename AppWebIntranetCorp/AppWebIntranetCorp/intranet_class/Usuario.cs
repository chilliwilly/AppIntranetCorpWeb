using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebIntranetCorp.intranet_class
{
    public class Usuario
    {
        public String usuario_nom { get; set; }
        public String usuario_usr { get; set; }
        public String usuario_num { get; set; }//perfil usuario
        public String usuario_pwd { get; set; }

        public Usuario() { }

        public Usuario(String usuario_nom, String usuario_usr, String usuario_num, String usuario_pwd) 
        {
            this.usuario_nom = usuario_nom;
            this.usuario_usr = usuario_usr;
            this.usuario_num = usuario_num;
            this.usuario_pwd = usuario_pwd;
        }
    }
}