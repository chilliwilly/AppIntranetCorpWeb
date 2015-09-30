using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebIntranetCorp.intranet_class
{
    public class Menu
    {
        public String menu_nom { get; set; }//nombre
        public String menu_gru { get; set; }//grupo
        public String menu_dep { get; set; }//dependencia
        public String menu_fun { get; set; }//funcion
        public String menu_url { get; set; }//direccion pagina

        public Menu() { }
    }
}