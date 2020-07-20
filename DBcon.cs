using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ShopManagementSystem
{
    public class DBcon
    {
        private static SqlConnection sqcon;
        
        public static SqlConnection Sqcon
        {
            get
            {
                if(sqcon==null)
                {
                    sqcon = new SqlConnection(@"Data Source=DESKTOP-UEL0Q0H;Initial Catalog=ShopManagement;Integrated Security=True");
                }
                else if(sqcon.State!=ConnectionState.Open)
                {
                    sqcon.Open();
                }
                return sqcon;
            }
        }
        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            return sqcom.ExecuteNonQuery();
        }

    }
}
