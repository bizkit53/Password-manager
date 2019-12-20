using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    [Serializable]
    public class NormalUser : User
    {
        private List<Record> records;

        public List<Record> Records { get => records; set => records = value; }

        public NormalUser() : base()
        {
            Records = new List<Record>();
        }

        public NormalUser(string login, string password, List<Record> records) : base (login, password)
        {
            Records = records;
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
    }
}
