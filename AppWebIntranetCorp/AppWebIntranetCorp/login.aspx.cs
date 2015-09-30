using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebIntranetCorp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //txtUser.Text = System.Environment.UserName;  
                String txtUsr = "$('#inputEmail').val('" + System.Environment.UserName + "');";
                ClientScript.RegisterStartupScript(typeof(string), "ServerControlScript", txtUsr, true);
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            String u = String.Format("{0}", Request.Form["username"]);// txtUser.Text;
            String p = String.Format("{0}", Request.Form["password"]);// txtPwd.Text;
            String Usuario = "";
            String Privilegios = "";
            String NomUsuario = "";

            intranet_lb.lb_login login = new intranet_lb.lb_login();

            login.llenaUsuario(u);

            if (login.existeUsuario(u))
            {
                if (!login.existePassword(p))
                {
                    String notificacionUno = "alert(\"Password en blanco.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", notificacionUno, true);
                    Response.AddHeader("REFRESH", "0.5;URL=login.aspx");
                }
                else
                {
                    //String notificacionUno = "alert(\"Existe password validar que sea igual y redireccione.\");";
                    //ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", notificacionUno, true);

                    intranet_class.Usuario usuario = login.llenaUsuario(u);

                    Usuario = usuario.usuario_usr;
                    Privilegios = usuario.usuario_num;
                    NomUsuario = usuario.usuario_nom;

                    HttpCookie cookie_priv = new HttpCookie("Privilegios");
                    HttpCookie cookie_usrs = new HttpCookie("Usuario");
                    HttpCookie cookie_nusr = new HttpCookie("NomUsuario");
                    cookie_priv.Value = Privilegios;
                    cookie_usrs.Value = Usuario;
                    cookie_nusr.Value = NomUsuario;
                    cookie_priv.Expires = DateTime.Now.AddMinutes(45);
                    cookie_usrs.Expires = DateTime.Now.AddMinutes(45);
                    cookie_nusr.Expires = DateTime.Now.AddMinutes(45);
                    Response.Cookies.Add(cookie_priv);
                    Response.Cookies.Add(cookie_usrs);
                    Response.Cookies.Add(cookie_nusr);

                    Response.AddHeader("REFRESH", "0.5;URL=introduccion.aspx");
                }
            }
            else
            {
                String notificacionUno = "alert(\"EL usuario no existe, contacte con administrador.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", notificacionUno, true);
                Response.AddHeader("REFRESH", "0.5;URL=login.aspx");
            }
        }


    }
}