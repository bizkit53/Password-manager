using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace PasswordManager
{
    [Serializable]
    public class User
    {
        private string login;
        private string password;
        private List<Record> records;

        public User()
        {
            this.login = "";
            this.password = "";
            this.records = new List<Record>();
        }

        public User(string login, string password, List<Record> records)
        {
            this.login = login;
            this.password = password;
            this.records = records;
        }

        private string setPassword(string password)
        {
            if (passwordStrength(password) == true)
                return password;
            else
                MessageBox.Show("Choose stronger password!");

            return "";
        }

        private bool passwordStrength(string password)
        {
            int score = 0;

            if (password.Length >= 8)
                score++;
            if (password.Any(c => char.IsUpper(c)))
                score++;
            if (password.Any(c => char.IsLower(c)))
                score++;
            if (password.Any(c => char.IsNumber(c)))
                score++;

            if (score >= 4)
                return true;
            else
                return false;
        }

        public void AddRecord(string serviceName, string login, string password, string serviceURL, categories category)
        {
            Record newRecord = new Record(serviceName, login, password, serviceURL, category);
            records.Add(newRecord);
        }

        public void DeleteRecord(Record record)
        {
            records.Remove(record);
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = setPassword(value); }
        public List<Record> Records { get => records; set => records = value; }
    }
}
