using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebIntranetCorp
{
    public partial class Site : System.Web.UI.MasterPage
    {
        String ColumnaPrivilegio;
        intranet_lb.lb_menu objMenu;

        protected void Page_Load(object sender, EventArgs e)
        {
            objMenu = new intranet_lb.lb_menu();

            #region Selecciona Columna Privilegio

            if (Request.Cookies["Privilegios"] != null)
            {
                if (Request.Cookies["Privilegios"].Value == "1")
                    ColumnaPrivilegio = "Nro_Funcion_1";
                if (Request.Cookies["Privilegios"].Value == "2")
                    ColumnaPrivilegio = "Nro_Funcion_2";
                if (Request.Cookies["Privilegios"].Value == "3")
                    ColumnaPrivilegio = "Nro_funcion_3";
                if (Request.Cookies["Privilegios"].Value == "4")
                    ColumnaPrivilegio = "Nro_funcion_4";
                if (Request.Cookies["Privilegios"].Value == "5")
                    ColumnaPrivilegio = "Nro_funcion_5";
                if (Request.Cookies["Privilegios"].Value == "6")
                    ColumnaPrivilegio = "Nro_funcion_6";
                if (Request.Cookies["Privilegios"].Value == "7")
                    ColumnaPrivilegio = "Nro_funcion_7";
                if (Request.Cookies["Privilegios"].Value == "8")
                    ColumnaPrivilegio = "Nro_funcion_8";
                if (Request.Cookies["Privilegios"].Value == "9")
                    ColumnaPrivilegio = "Nro_funcion_9";
                if (Request.Cookies["Privilegios"].Value == "10")
                    ColumnaPrivilegio = "Nro_funcion_10";
                if (Request.Cookies["Privilegios"].Value == "11")
                    ColumnaPrivilegio = "Nro_funcion_11";
                if (Request.Cookies["Privilegios"].Value == "12")
                    ColumnaPrivilegio = "Nro_funcion_12";
                if (Request.Cookies["Privilegios"].Value == "13")
                    ColumnaPrivilegio = "Nro_funcion_13";
                if (Request.Cookies["Privilegios"].Value == "14")
                    ColumnaPrivilegio = "Nro_funcion_14";
                if (Request.Cookies["Privilegios"].Value == "15")
                    ColumnaPrivilegio = "Nro_funcion_15";
                if (Request.Cookies["Privilegios"].Value == "16")
                    ColumnaPrivilegio = "Nro_funcion_16";
                if (Request.Cookies["Privilegios"].Value == "17")
                    ColumnaPrivilegio = "Nro_funcion_17";
                if (Request.Cookies["Privilegios"].Value == "18")
                    ColumnaPrivilegio = "Nro_funcion_18";
                if (Request.Cookies["Privilegios"].Value == "19")
                    ColumnaPrivilegio = "Nro_funcion_19";
                if (Request.Cookies["Privilegios"].Value == "20")
                    ColumnaPrivilegio = "Nro_funcion_20";
                if (Request.Cookies["Privilegios"].Value == "21")
                    ColumnaPrivilegio = "Nro_funcion_21";
                if (Request.Cookies["Privilegios"].Value == "22")
                    ColumnaPrivilegio = "Nro_funcion_22";
                if (Request.Cookies["Privilegios"].Value == "23")
                    ColumnaPrivilegio = "Nro_funcion_23";
                if (Request.Cookies["Privilegios"].Value == "24")
                    ColumnaPrivilegio = "Nro_funcion_24";
                if (Request.Cookies["Privilegios"].Value == "25")
                    ColumnaPrivilegio = "Nro_funcion_25";
                if (Request.Cookies["Privilegios"].Value == "26")
                    ColumnaPrivilegio = "Nro_funcion_26";
                if (Request.Cookies["Privilegios"].Value == "27")
                    ColumnaPrivilegio = "Nro_funcion_27";
                if (Request.Cookies["Privilegios"].Value == "28")
                    ColumnaPrivilegio = "Nro_funcion_28";
                if (Request.Cookies["Privilegios"].Value == "29")
                    ColumnaPrivilegio = "Nro_funcion_29";
                if (Request.Cookies["Privilegios"].Value == "30")
                    ColumnaPrivilegio = "Nro_funcion_30";
                if (Request.Cookies["Privilegios"].Value == "31")
                    ColumnaPrivilegio = "Nro_funcion_31";
                if (Request.Cookies["Privilegios"].Value == "32")
                    ColumnaPrivilegio = "Nro_funcion_32";
                if (Request.Cookies["Privilegios"].Value == "33")
                    ColumnaPrivilegio = "Nro_funcion_33";
                if (Request.Cookies["Privilegios"].Value == "34")
                    ColumnaPrivilegio = "Nro_funcion_34";
                if (Request.Cookies["Privilegios"].Value == "35")
                    ColumnaPrivilegio = "Nro_funcion_35";
                if (Request.Cookies["Privilegios"].Value == "36")
                    ColumnaPrivilegio = "Nro_funcion_36";                

                if (ColumnaPrivilegio != "")
                {
                    BindMenuControl(ColumnaPrivilegio);
                }
                else
                {
                    Response.Redirect("~/login.aspx");//Response.Redirect
                }
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }

            #endregion

            if (!IsPostBack) 
            {
                GetMenuData();
            }
        }

        protected void BindMenuControl(String colPrivilegio)
        {
            objMenu = new intranet_lb.lb_menu();
            String reqCookie = Request.Cookies["Privilegios"].Value.ToString();

            foreach (intranet_class.Menu m in objMenu.getMenu(reqCookie))
            {
                MenuItem mItem = new MenuItem(m.menu_nom, m.menu_dep, m.menu_gru, m.menu_url);
                //Menu1.Items.Add(mItem);
                AddChildItem(ref mItem, reqCookie);
            }
        }

        protected void AddChildItem(ref MenuItem mItem, String idFuncion)
        {
            objMenu = new intranet_lb.lb_menu();
            foreach (intranet_class.Menu m in objMenu.getSubMenu(idFuncion))
            {
                if (Convert.ToInt32(m.menu_gru) == Convert.ToInt32(mItem.Value) && Convert.ToInt32(m.menu_dep) != Convert.ToInt32(m.menu_gru))
                {
                    MenuItem miSubItem = new MenuItem(m.menu_nom, m.menu_dep, String.Empty, m.menu_url);
                    mItem.ChildItems.Add(miSubItem);
                    AddChildItem(ref miSubItem, idFuncion);
                }
            }
        }

        public void GetMenuData()
        {
            String reqCookie = Request.Cookies["Privilegios"].Value.ToString();
            String _menuUrl = "";
            objMenu = new intranet_lb.lb_menu();
            StringBuilder objstr = new StringBuilder();
            List<intranet_class.Menu> objpmenu = new List<intranet_class.Menu>();
            List<intranet_class.Menu> objcmenu = new List<intranet_class.Menu>();
            objpmenu = objMenu.getMenu(reqCookie);
            objcmenu = objMenu.getSubMenu(reqCookie);
            objstr.Append("<li class=\"header\">MENU PRINCIPAL</li>");

            //codigo para obtener el nivel 1 del menu
            foreach (intranet_class.Menu _pitem in objpmenu)
            {
                if (String.IsNullOrEmpty(_pitem.menu_url))
                {
                    _menuUrl = "#";
                }
                else
                {
                    _menuUrl = _pitem.menu_url;
                }

                //inicio li treeview nivel 1
                //objstr.Append("<li class=\"treeview\"><a href='" + _menuUrl + "'><i class=\"fa fa-share\"></i><span>" + _pitem.menu_nom + "</span><i class=\"fa fa-angle-left pull-right\"></i></a>");

                //codigo para obtener el nivel 2 del menu
                var childitem = objcmenu.Where(m => m.menu_gru == _pitem.menu_dep).ToList();

                if (childitem.Count > 1)
                {
                    objstr.Append("<li class=\"treeview\"><a href='" + _menuUrl + "'><i class=\"fa fa-share\"></i><span>" + _pitem.menu_nom + "</span><i class=\"fa fa-angle-left pull-right\"></i></a>");
                }
                else 
                {
                    objstr.Append("<li class=\"treeview\"><a href='" + _menuUrl + "'><i class=\"fa fa-share\"></i><span>" + _pitem.menu_nom + "</span></a>");
                }

                if (childitem.Count > 1)//0
                {
                    //inicio ul treeview-menu nivel 2
                    objstr.Append("<ul class=\"treeview-menu\">");
                    foreach (var _citem in childitem)
                    {
                        if (!(_citem.menu_dep == _pitem.menu_dep))
                        {
                            #region Nivel 2 Interior

                            if (String.IsNullOrEmpty(_citem.menu_url))
                            {
                                _menuUrl = "#";
                            }
                            else
                            {
                                _menuUrl = _citem.menu_url;
                            }

                            //inicio li treeview-menu nivel 2
                            //objstr.Append("<li><a href='" + _menuUrl + "'><i class=\"fa fa-circle-o\"></i>" + _citem.menu_nom + "<i class=\"fa fa-angle-left pull-right\"></i></a>");

                            //codigo para obtener el nivel 3 del menu
                            var subchilditem = objcmenu.Where(m => m.menu_gru == _citem.menu_dep).ToList();

                            if (subchilditem.Count > 0)
                            {
                                objstr.Append("<li><a href='" + _menuUrl + "'><i class=\"fa fa-circle-o\"></i>" + _citem.menu_nom + "<i class=\"fa fa-angle-left pull-right\"></i></a>");
                            }
                            else
                            {
                                objstr.Append("<li><a href='" + _menuUrl + "'><i class=\"fa fa-circle-o\"></i>" + _citem.menu_nom + "</a>");
                            }

                            if (subchilditem.Count > 0)
                            {
                                //inicio ul treeview-menu nivel 3
                                objstr.Append("<ul class=\"treeview-menu\">");
                                foreach (var _csitem in subchilditem)
                                {
                                    objstr.Append("<li><a href='" + _csitem.menu_url + "'><i class=\"fa fa-circle-o\"></i>" + _csitem.menu_nom + "</a></li>");
                                }
                                //fin ul treeview-menu nivel 3
                                objstr.Append("</ul>");
                            }
                            //fin li treeview-menu nivel 2
                            objstr.Append("</li>");

                            #endregion
                        }
                    }
                    //fin ul treeview-menu nivel 2
                    objstr.Append("</ul>");
                }
                //fin li treeview nivel 1
                objstr.Append("</li>");
            }
            inicio.InnerHtml = objstr.ToString();
        }
    }
}