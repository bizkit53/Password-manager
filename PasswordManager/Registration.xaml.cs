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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        UserList users;

        public Registration(UserList users)
        {
            this.users = users;
            InitializeComponent();
        }

        private void button_register_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User();

            if(users.CheckIfLoginExist(textBox_login.Text) == false)
                newUser.Login = textBox_login.Text;

            if (passwordBox_password.Password.ToString() == passwordBox_repeatPassword.Password.ToString())
                newUser.Password = passwordBox_password.Password.ToString();
            else
                MessageBox.Show("Passwords are different!");

            if (newUser.Login != "" && newUser.Password != "")
            {
                users.AddUser(newUser);
                MessageBox.Show("Registration successful!");
                MainWindow main = new MainWindow(users);
                main.Show();
                this.Close();
            }
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(users);
            main.Show();
            this.Close();
        }
    }
}
