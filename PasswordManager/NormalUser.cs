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
            SortRecords();
        }

        public void DeleteRecord(Record record)
        {
            records.Remove(record);
        }

        public void SortRecords()
        {
            for (int i = 0; i < Records.Count - 1; i++)
            {
                if (Records[i].ServiceName.CompareTo(Records[i + 1].ServiceName) == 1)
                {
                    var temp = Records[i];
                    Records[i] = Records[i + 1];
                    Records[i + 1] = temp;
                    i = -1;
                }
            }
        }
    }
}
