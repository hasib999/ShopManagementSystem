using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ShopManagementSystem.UserLogIn
{
    public class loginClass
    {
       public loginClass()
        {

        }
        private DBcon Da = new DBcon();
        private DataSet Ds = new DataSet();

        string id { get; set; }
        string password { get; set; }

        string sql { set; get; }

        public bool IsAdminValid(string id , string password)
        {
            this.sql = "select *from login where userid= '" + id + "' and password = '" + password + "' and usertype='Admin';";
            this.Ds = DBcon.GetDataSet(sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsEmployeeValid(string id, string password)
        {
            this.sql = "select * from Login where userid ='" + id + "'and password ='" + password + "'and usertype ='Employee';";
            this.Ds = DBcon.GetDataSet(sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
                return false;

        }

        public int IsLogInValid(string id, string password)
        {
            this.sql = "select * from Login where userid ='" + id + "'and password ='" + password + "';";
            this.Ds = DBcon.GetDataSet(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {

                if (IsAdminValid(id, password) == true)
                {
                    return 1;
                }
                else if (IsEmployeeValid(id, password) == true)
                {
                    return 2;
                }
                else 
                {
                    return 0;
                }
                    
                
            }
            else
            {
                return 0;
            }


        }


    }
}
