using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OpusFinder
{
    internal class conexiones
    {
        private static string cadenaConexion = "Data Source=DESKTOP-HTNGQBS;Initial Catalog=CV;User ID=sa;Password=Nosenada01;Encrypt=True";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            con.Open();
            return con;
        }
    }
}
