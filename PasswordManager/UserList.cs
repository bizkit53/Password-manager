using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasswordManager
{
    [Serializable]
    public class UserList
    {
        private List<User> users;

        public List<User> Users { get => users; set => users = value; }

        public UserList()
        {
            this.users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }

        public bool CheckIfLoginExist(string login)
        {
            foreach (User user in users)
                if (login == user.Login)
                    return true;

            return false;
        }


        
        public static void SaveXML(string path, UserList users)
        {
            var serializer = new XmlSerializer(typeof(UserList));
            var inputStream = new StreamWriter(path);
            serializer.Serialize(inputStream, users);
            inputStream.Close();
        }

        public static UserList ReadXML(string path)
        {
            UserList output = null;

            XmlSerializer serializer = new XmlSerializer(typeof(UserList));

            StreamReader reader = new StreamReader(path);
            output = (UserList)serializer.Deserialize(reader);
            reader.Close();
            return output;
        }
    }
}
