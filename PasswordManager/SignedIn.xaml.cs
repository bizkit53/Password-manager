using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for SignedIn.xaml
    /// </summary>
    [Serializable]
    public partial class SignedIn : Window
    {
        UserList users;
        User user;

        public SignedIn(UserList users, User user)
        {
            this.users = users;
            this.user = user;
            InitializeComponent();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(users);
            main.Show();
            this.Close();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            AddRecord add = new AddRecord(users, user);
            add.Show();
            this.Close();
        }
    }
}
