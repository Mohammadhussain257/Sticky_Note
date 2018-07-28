using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
   public class DbConnection
    {
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-J0E7DV5\SQLEXPRESS;Initial Catalog=Mohammad_sticky_note;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public void manipulateInfo(string sql)
        {
            conection.Open();
            cmd.Connection = conection;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conection.Close();
        }
        public DataTable retrieveInfo(string sql)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(sql, conection);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
