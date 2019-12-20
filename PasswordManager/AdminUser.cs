using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    [Serializable]
    public class AdminUser : User
    {
        public AdminUser() : base()
        {
        }

        public AdminUser(string login, string password) : base(login, password)
        {
        }
    }
}
