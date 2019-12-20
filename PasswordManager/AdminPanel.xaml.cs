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
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        UserList users;
        AdminUser user;
        ObservableCollection<User> list;

        public AdminPanel(UserList users, AdminUser user)
        {
            this.users = users;
            this.user = user;
            InitializeComponent();
            foreach (User User in users.Users)
            {
                if (!(user is AdminUser)) 
                    list.Add(User);
            }
            listBox_users.ItemsSource = list;
            textBox_user.Text = "User: " + user.Login;
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_show_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
