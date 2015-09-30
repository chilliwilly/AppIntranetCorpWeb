using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppWebIntranetCorp.intranet_ld
{
    public class ld_login
    {
        private static String conStr = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion_DB_Intranet"].ConnectionString;

        public DataTable selectUsuario(String usr) 
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conStr)) 
            {
                con.Open();
                String qry = "SELECT NOMBRE + ' ' + AP_PATERNO AS USR_NOMBRE, USUARIO AS USR_USUARIO, PERFIL_USUARIO AS USR_PERFIL, PWD_CODE AS USR_PASSWORD FROM USUARIO WHERE USUARIO = @IN_USR ";
                using (SqlCommand cmd = new SqlCommand(qry, con)) 
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("IN_USR", SqlDbType.VarChar)).Value = usr;
                    cmd.Parameters["IN_USR"].Direction = ParameterDirection.Input;

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