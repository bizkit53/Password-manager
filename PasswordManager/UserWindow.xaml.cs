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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        UserList users;
        AdminUser admin;
        User user;

        public UserWindow(UserList users, AdminUser admin, User user)
        {
            this.users = users;
            this.admin = admin;
            this.user = user;
            InitializeComponent();
        }

        private void button_apply_Click(object sender, RoutedEventArgs e)
        {
            user.Password = textBox_password.Text;
            if (user.Password == textBox_password.Text)
            {
                AdminPanel panel = new AdminPanel(users, admin);
                panel.Show();
                this.Close();
            }
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel panel = new AdminPanel(users, admin);
            panel.Show();
            this.Close();
        }
    }
}
