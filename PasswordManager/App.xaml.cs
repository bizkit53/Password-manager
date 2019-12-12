﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PasswordManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    [Serializable]
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            UserList users = new UserList();

            var application = new App();
            MainWindow window = new MainWindow(users);
           // application.InitializeComponent();
            application.Run(window);
        }
    }
}