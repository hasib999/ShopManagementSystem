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
using System.Data;
using System.Data.SqlClient;

namespace ShopManagementSystem.UserLogIn
{
    /// <summary>
    /// Interaction logic for UserLogIn.xaml
    /// </summary>
    public partial class UserLogIn : Window
    {
        loginClass l = new loginClass();
        string id { get; set; }
        string password { get; set; }
        int result { get; set; }
        public UserLogIn()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            string tx = passtxtbox.Text;
            
            if(tx.Length>=8)
            {
                this.id = this.idtxtbox.Text;
                this.password = this.passtxtbox.Text;
                this.result = this.l.IsLogInValid(id, password);

                if (result == 1)
                {
                    this.Hide();
                    Admin.Admin a = new Admin.Admin();
                    a.Show();
                }
                else if (result == 2)
                {
                    this.Hide();
                    Employee.Employee ee = new Employee.Employee();
                    ee.Show();
                }
                else if (result == 0)
                {
                    MessageBox.Show("Invalid ID or Password");
                }
                else { }
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }

        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
