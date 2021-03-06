﻿using System;
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
    /// Interaction logic for RecordWindow.xaml
    /// </summary>
    public partial class RecordWindow : Window
    {
        UserList users;
        NormalUser user;
        Record record;

        public RecordWindow(UserList users, NormalUser user, Record record)
        {
            this.users = users;
            this.user = user;
            this.record = record;
            InitializeComponent();
            textBox_serviceName.Text = record.ServiceName;
            textBox_login.Text = record.Login;
            textBox_password.Text = record.Password;
            textBox_URL.Text = record.ServiceURL;
            comboBox_category.SelectedIndex = (int)record.Category;
        }

        public RecordWindow(UserList users, NormalUser user)
        {
            this.users = users;
            this.user = user;
            InitializeComponent();
        }

        private void button_apply_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_serviceName.Text != "" && textBox_login.Text != "" && textBox_password.Text != "" && comboBox_category.SelectedItem != null)
            {
                record.ServiceName = textBox_serviceName.Text;
                record.Login = textBox_login.Text;
                record.Password = textBox_password.Text;
                record.ServiceURL = textBox_URL.Text;
                record.Category = (categories)comboBox_category.SelectedIndex;
                MessageBox.Show("Record successfully edited.");

                SignedIn signedIn = new SignedIn(users, user);
                signedIn.Show();
                this.Close();
            }
            else
                MessageBox.Show("Not enough information.");
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            SignedIn signedIn = new SignedIn(users, user);
            signedIn.Show();
            this.Close();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_serviceName.Text != "" && textBox_login.Text != "" && textBox_password.Text != "" && comboBox_category.SelectedItem != null)
            {
                user.AddRecord(textBox_serviceName.Text, textBox_login.Text, textBox_password.Text, textBox_URL.Text, (categories)comboBox_category.SelectedIndex);
                MessageBox.Show("Record successfully added.");
                SignedIn signedIn = new SignedIn(users, user);
                signedIn.Show();
                this.Close();
            }
            else
                MessageBox.Show("Not enough information.");
        }
    }
}
