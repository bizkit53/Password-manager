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
        ObservableCollection<Record> list;

        public SignedIn(UserList users, User user)
        {
            this.users = users;
            this.user = user;
            InitializeComponent();
            list = new ObservableCollection<Record>(user.Records);
            listBox_records.ItemsSource = list;
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
                EditRecord edit = new EditRecord(users, user, (Record)listBox_records.SelectedItem);
                edit.Show();
                this.Close();
            }
        }

        private void button_show_Click(object sender, RoutedEventArgs e)
        {
            ShowRecord edit = new ShowRecord(users, user, (Record)listBox_records.SelectedItem);
            edit.Show();
            this.Close();
        }
    }
}
