using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppWebIntranetCorp.intranet_ld
{
    public class ld_menu
    {
        private static String conStr = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion_DB_Intranet"].ConnectionString;

        //consulta que selecciona menu de acuerdo a la funcion
        public DataTable selectMenu(String query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
                con.Close();
            }

            return dt;
        }
    }
}