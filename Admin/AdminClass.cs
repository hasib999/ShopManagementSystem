using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ShopManagementSystem.Admin
{
    public class AdminClass
    {
        private DBcon Da { get; set; }

        private DataSet Ds { get; set; }

        public AdminClass()
        {
            this.Da = new DBcon();
        }
        public AdminClass(string userid,string name,string gender,string email,string phone,string dob)
        {
            this.Da = new DBcon();
            this.userid = userid;
            this.name = name;
            this.gender = gender;
            this.email = email;
            this.phone = phone;
            this.dob = dob;

        }
        string userid { get; set; }
        string name { get; set; }
        string gender { get; set; }
        string email { get; set; }
        string phone { get; set; }
        string dob { get; set; }
    }
}
