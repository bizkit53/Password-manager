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

namespace PasswordManager
{
    /// <summary>
    /// Interaction logic for ShowRecord.xaml
    /// </summary>
    public partial class ShowRecord : Window
    {
        UserList users;
        User user;

        public ShowRecord(UserList users, User user, Record record)    // edit record
        {
            this.users = users;
            this.user = user;
            InitializeComponent();
            textBox_serviceName.Text = record.ServiceName;
            textBox_login.Text = record.Login;
            textBox_password.Text = record.Password;
            textBox_URL.Text = record.ServiceURL;
            textBox_category.Text = record.Category.ToString();
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            SignedIn signedIn = new SignedIn(users, user);
            signedIn.Show();
            this.Close();
        }
    }
}
