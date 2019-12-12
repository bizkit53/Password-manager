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
    /// Interaction logic for SignedIn.xaml
    /// </summary>
    [Serializable]
    public partial class SignedIn : Window
    {
        UserList users;

        public SignedIn(UserList users)
        {
            this.users = users;
            InitializeComponent();
        }
    }
}
