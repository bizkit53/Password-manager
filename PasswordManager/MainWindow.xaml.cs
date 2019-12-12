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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserList users;

        public MainWindow(UserList users)
        {
            this.users = users;

            InitializeComponent();
        }

        private void button_signIn_Click(object sender, RoutedEventArgs e)
        {
            foreach (User user in users.Users)
                if (textBox_login.Text == user.Login)
                    if (passwordBox_password.Password.ToString() == user.Password)
                    {
                        SignedIn signedIn = new SignedIn(users);
                        signedIn.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Wrong password.");
                else
                    MessageBox.Show("User not exists.");
        }

        private void button_register_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration(users);
            registration.Show();
            this.Close();
        }
    }
}
