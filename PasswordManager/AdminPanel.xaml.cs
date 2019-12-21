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
            list = new ObservableCollection<User>(users.Users);
            listBox_users.ItemsSource = list;
            textBox_user.Text = "(Admin)User: " + user.Login;
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(users);
            main.Show();
            this.Close();
        }

        private void button_show_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_users.SelectedItem != null)
            {
                User userToShow = (User)listBox_users.SelectedItem;
                UserWindow window = new UserWindow(users, user, userToShow);
                window.Title = "Password manager: User details";
                window.label_show.Visibility = Visibility.Visible;
                window.label_edit.Visibility = Visibility.Hidden;
                window.textBox_login.Text = userToShow.Login;
                window.textBox_password.Text = userToShow.Password;
                window.textBox_password.IsEnabled = false;
                window.button_cancel.IsDefault = true;
                window.Show();
                this.Close();
            }
        }

        private void button_addAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminUser adminUser = new AdminUser();
            Registration registration = new Registration(users, adminUser, user);
            registration.Title = "Password manager: Admin registration";
            registration.label_registration.Content = "Add new admin";
            registration.label_registration.Width = 100;
            registration.Show();
            this.Close();
        }

        private void button_edit_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_users.SelectedItem != null)
            {
                User userToEdit = (User)listBox_users.SelectedItem;
                UserWindow window = new UserWindow(users, user, userToEdit);
                window.Title = "Password manager: Edit user";
                window.label_show.Visibility = Visibility.Hidden;
                window.label_edit.Visibility = Visibility.Visible;
                window.textBox_login.Text = userToEdit.Login;
                window.textBox_password.Text = userToEdit.Password;
                window.button_apply.Visibility = Visibility.Visible;
                window.button_apply.IsDefault = true;
                window.Show();
                this.Close();
            }
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_users.SelectedItem == this.user)
                MessageBox.Show("You can't delete active admin user!");
            else
                if (listBox_users.SelectedItem != null)
                {
                    MessageBoxResult result = MessageBox.Show("Do you really want to delete " + listBox_users.SelectedItem.ToString(), "Delete user", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                    {
                        User userRemove = (User)listBox_users.SelectedItem;
                        users.DeleteUser(userRemove);
                        list.Remove(userRemove);
                    }
                }
        }
    }
}
