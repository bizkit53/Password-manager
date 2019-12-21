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
        NormalUser user;
        ObservableCollection<Record> list;

        public SignedIn(UserList users, NormalUser user)
        {
            this.users = users;
            this.user = user;
            InitializeComponent();
            list = new ObservableCollection<Record>(user.Records);
            listBox_records.ItemsSource = list;
            textBox_user.Text = "User: " + user.Login;
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(users);
            main.Show();
            this.Close();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            RecordWindow add = new RecordWindow(users, user);
            add.Title = "Password manager: Add record";
            add.button_apply.Visibility = Visibility.Hidden;
            add.button_add.IsDefault = true;
            add.Show();
            this.Close();
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_records.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Do you really want to delete " + listBox_records.SelectedItem.ToString(), "Delete record", MessageBoxButton.YesNo);
                
                if (result == MessageBoxResult.Yes)
                {
                    Record record = (Record)listBox_records.SelectedItem;
                    user.DeleteRecord(record);
                    list.Remove(record);
                }
            }
        }

        private void button_edit_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_records.SelectedItem != null)
            {
                RecordWindow edit = new RecordWindow(users, user, (Record)listBox_records.SelectedItem);
                edit.Title = "Password manager: Edit record";
                edit.button_add.Visibility = Visibility.Hidden;
                edit.button_apply.IsDefault = true;
                edit.Show();
                this.Close();
            }
        }

        private void button_show_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_records.SelectedItem != null)
            {
                RecordWindow show = new RecordWindow(users, user, (Record)listBox_records.SelectedItem);
                show.Title = "Password manager: Show record";
                show.textBox_serviceName.IsEnabled = false;
                show.textBox_login.IsEnabled = false;
                show.textBox_password.IsEnabled = false;
                show.textBox_URL.IsEnabled = false;
                show.comboBox_category.IsEnabled = false;
                show.button_apply.Visibility = Visibility.Hidden;
                show.button_add.Visibility = Visibility.Hidden;
                show.button_cancel.IsDefault = true;
                show.Show();
                this.Close();
            }
        }

        private void button_filterCategory_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox_category.SelectedItem != null && comboBox_category.SelectedIndex != comboBox_category.Items.Count -1)
            {
                list.Clear();
                foreach (Record record in user.Records)
                    if (comboBox_category.SelectedIndex == (int)record.Category)
                        list.Add(record);
            }
            else
            {
                list.Clear();
                foreach (Record record in user.Records)
                    list.Add(record);
            }
        }

        private void button_copy_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_records.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Do you want to copy " + listBox_records.SelectedItem.ToString(), "Copy record", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    Record record = (Record)listBox_records.SelectedItem;
                    Record newRecord = (Record)record.Clone();
                    user.AddRecord(newRecord);
                    list = new ObservableCollection<Record>(user.Records);
                    listBox_records.ItemsSource = list;
                }
            }
        }
    }
}
