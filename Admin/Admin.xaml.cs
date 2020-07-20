using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ShopManagementSystem.Admin;
using System.Data;
using System.Data.SqlClient;

namespace ShopManagementSystem.Admin
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        
        internal string userid { get; set; }
        private DBcon Da { get; set; }
        private DataSet Ds { get; set; }
        public Admin()
        {
            //this.Da = new DBcon();
            InitializeComponent();

        }
        public Admin(string id)
        {
            this.userid = id;
            this.Da = new DBcon();
            InitializeComponent();
            this.AdminProfile();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            UserLogIn.UserLogIn u = new UserLogIn.UserLogIn();
            u.Show();
            this.Hide();
        }
        public void AdminProfile()
        {
            string sql = "Select * from login";
            DataTable dt = new DataTable();
            dt = DBcon.GetDataTable(sql);
            
            if(dt.Rows.Count>0)
            {
                lblid.Content = dt.Rows[0]["userid"].ToString();
                lblname.Content = dt.Rows[0]["name"].ToString();
            }
            
        }
    }
}
