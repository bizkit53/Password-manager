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

    [Serializable]
    public partial class Registration : Window
    {
        UserList users;
        User newUser;
        AdminUser loggedInAdmin;

        public Registration(UserList users, User user)
        {
            this.users = users;
            this.newUser = user;
            InitializeComponent();
        }

        public Registration(UserList users, User user, AdminUser admin)
        {
            this.users = users;
            this.newUser = user;
            this.loggedInAdmin = admin;
            InitializeComponent();
        }

        private void button_register_Click(object sender, RoutedEventArgs e)
        {
            if (users.CheckIfLoginExist(textBox_login.Text) == false)
            {
                newUser.Login = textBox_login.Text;

                if (passwordBox_password.Password.ToString() == passwordBox_repeatPassword.Password.ToString())
                    newUser.Password = passwordBox_password.Password.ToString();
                else
                    MessageBox.Show("Passwords are different!");
            }
            else
                MessageBox.Show("User " + textBox_login.Text + " already exists!");

            if (newUser.Login != "" && newUser.Password != "")
            {
                users.AddUser(newUser);
                MessageBox.Show("Registration successful!");
                openPreviousWindow();
            }
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            openPreviousWindow();
        }

        private void openPreviousWindow()
        {
            if (loggedInAdmin != null)
            {
                AdminPanel panel = new AdminPanel(users, loggedInAdmin);
                panel.Show();
            }
            else
            {
                MainWindow main = new MainWindow(users);
                main.Show();
            }
            this.Close();
        }
    }
}
