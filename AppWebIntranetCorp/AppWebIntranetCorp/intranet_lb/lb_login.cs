using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppWebIntranetCorp.intranet_lb
{
    public class lb_login
    {
        intranet_ld.ld_login login;
        intranet_class.Usuario user;

        public intranet_class.Usuario llenaUsuario(String usr) 
        {
            login = new intranet_ld.ld_login();

            DataTable dt = login.selectUsuario(usr);

            user = new intranet_class.Usuario();

            foreach (DataRow dr in dt.Rows) 
            {
                user.usuario_nom = dr["USR_NOMBRE"].ToString();
                user.usuario_usr = dr["USR_USUARIO"].ToString();
                user.usuario_num = dr["USR_PERFIL"].ToString();
                user.usuario_pwd = dr["USR_PASSWORD"].ToString();
            }

            return user;
        }

        public Boolean existeUsuario(String usr)
        {
            Boolean existe = false;

            if (user.usuario_usr == usr) 
            {
                existe = true;
            }

            return existe;
        }

        public Boolean existePassword(String pwd)
        {
            Boolean existe = false;

            if (user.usuario_pwd == codificaPassword(pwd)) 
            {
                existe = true;
            }

            return existe;
        }

        public String codificaPassword(String inPwd)
        {
            String pwdcod = "";

            System.Security.Cryptography.MD5CryptoServiceProvider pwd = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inPwd);
            data = pwd.ComputeHash(data);
            //string localPwd = "";
            for (int i = 0; i < data.Length; i++)
                pwdcod += data[i].ToString("x2").ToLower();

            return pwdcod;
        }
    }
}