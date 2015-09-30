using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppWebIntranetCorp.intranet_lb
{
    public class lb_menu
    {
        intranet_ld.ld_menu menu;

        //obtiene el nombre de la columna
        public String getColumnaFuncion(String funcion) 
        {
            String ColumnaPrivilegio = "";

            if (funcion == "1")
                ColumnaPrivilegio = "Nro_Funcion_1";
            if (funcion == "2")
                ColumnaPrivilegio = "Nro_Funcion_2";
            if (funcion == "3")
                ColumnaPrivilegio = "Nro_funcion_3";
            if (funcion == "4")
                ColumnaPrivilegio = "Nro_funcion_4";
            if (funcion == "5")
                ColumnaPrivilegio = "Nro_funcion_5";
            if (funcion == "6")
                ColumnaPrivilegio = "Nro_funcion_6";
            if (funcion == "7")
                ColumnaPrivilegio = "Nro_funcion_7";
            if (funcion == "8")
                ColumnaPrivilegio = "Nro_funcion_8";
            if (funcion == "9")
                ColumnaPrivilegio = "Nro_funcion_9";
            if (funcion == "10")
                ColumnaPrivilegio = "Nro_funcion_10";
            if (funcion == "11")
                ColumnaPrivilegio = "Nro_funcion_11";
            if (funcion == "12")
                ColumnaPrivilegio = "Nro_funcion_12";
            if (funcion == "13")
                ColumnaPrivilegio = "Nro_funcion_13";
            if (funcion == "14")
                ColumnaPrivilegio = "Nro_funcion_14";
            if (funcion == "15")
                ColumnaPrivilegio = "Nro_funcion_15";
            if (funcion == "16")
                ColumnaPrivilegio = "Nro_funcion_16";
            if (funcion == "17")
                ColumnaPrivilegio = "Nro_funcion_17";
            if (funcion == "18")
                ColumnaPrivilegio = "Nro_funcion_18";
            if (funcion == "19")
                ColumnaPrivilegio = "Nro_funcion_19";
            if (funcion == "20")
                ColumnaPrivilegio = "Nro_funcion_20";
            if (funcion == "21")
                ColumnaPrivilegio = "Nro_funcion_21";
            if (funcion == "22")
                ColumnaPrivilegio = "Nro_funcion_22";
            if (funcion == "23")
                ColumnaPrivilegio = "Nro_funcion_23";
            if (funcion == "24")
                ColumnaPrivilegio = "Nro_funcion_24";
            if (funcion == "25")
                ColumnaPrivilegio = "Nro_funcion_25";
            if (funcion == "26")
                ColumnaPrivilegio = "Nro_funcion_26";
            if (funcion == "27")
                ColumnaPrivilegio = "Nro_funcion_27";
            if (funcion == "28")
                ColumnaPrivilegio = "Nro_funcion_28";
            if (funcion == "29")
                ColumnaPrivilegio = "Nro_funcion_29";
            if (funcion == "30")
                ColumnaPrivilegio = "Nro_funcion_30";
            if (funcion == "31")
                ColumnaPrivilegio = "Nro_funcion_31";
            if (funcion == "32")
                ColumnaPrivilegio = "Nro_funcion_32";
            if (funcion == "33")
                ColumnaPrivilegio = "Nro_funcion_33";
            if (funcion == "34")
                ColumnaPrivilegio = "Nro_funcion_34";
            if (funcion == "35")
                ColumnaPrivilegio = "Nro_funcion_35";
            if (funcion == "36")
                ColumnaPrivilegio = "Nro_funcion_36";

            return ColumnaPrivilegio;
        }

        //genera string select para pasarlo a ld_menu
        //y realizar la consulta
        public String getQueryMenu(String funcion) 
        {
            String qry = "";

            qry = "SELECT ID_MENU, NOMBRE_MENU, GRUPO_MENU, LINK_MENU FROM MENU WHERE " + getColumnaFuncion(funcion) + " = " + funcion + " ORDER BY GRUPO_MENU ASC";

            return qry;
        }

        //lista de menu
        public List<intranet_class.Menu> getMenu(String funcion) 
        {
            menu = new intranet_ld.ld_menu();

            List<intranet_class.Menu> ls = new List<intranet_class.Menu>();

            DataTable dt = menu.selectMenu(getQueryMenu(funcion));

            if (dt != null && dt.Rows.Count > 0) 
            {
                foreach (DataRow dr in dt.Rows) 
                {
                    if (Convert.ToInt32(dr["ID_MENU"].ToString()) == Convert.ToInt32(dr["GRUPO_MENU"].ToString())) 
                    {
                        intranet_class.Menu m = new intranet_class.Menu();
                        m.menu_nom = dr["NOMBRE_MENU"].ToString();//nom menu
                        m.menu_dep = dr["ID_MENU"].ToString();//id menu
                        m.menu_gru = String.Empty; //grupo menu
                        m.menu_url = dr["LINK_MENU"].ToString();//url menu

                        ls.Add(m);
                    }
                }
            }

            return ls;
        }

        //lista de submenu
        public List<intranet_class.Menu> getSubMenu(String funcion) 
        {
            menu = new intranet_ld.ld_menu();

            List<intranet_class.Menu> ls = new List<intranet_class.Menu>();

            DataTable dt = menu.selectMenu(getQueryMenu(funcion));

            if (dt != null && dt.Rows.Count > 0) 
            {
                foreach (DataRow dr in dt.Rows)
                {
                    intranet_class.Menu m = new intranet_class.Menu();
                    m.menu_nom = dr["NOMBRE_MENU"].ToString();//nom menu
                    m.menu_dep = dr["ID_MENU"].ToString();//id menu
                    m.menu_gru = dr["GRUPO_MENU"].ToString();//grupo menu
                    m.menu_url = dr["LINK_MENU"].ToString();//url menu

                    ls.Add(m);
                }
            }

            return ls;
        }
    }
}