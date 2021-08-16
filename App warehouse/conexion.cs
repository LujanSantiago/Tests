using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace App_warehouse
{
    public class conexion
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=WIN-UFKCTF3II66\SQLEXPRESS;Initial Catalog=warehouse;User ID=jose;Password=12345");
        public SqlDataReader dr;
        public void abrir()
        {
            cn.Open();
        }
        public void cerrar()
        {
            cn.Close();
        }
        public void movimientos(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.ExecuteNonQuery();
        }
        public void consultas(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cn);
            dr = cmd.ExecuteReader();
        }
    }
}
