﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    [Serializable] 
    public enum categories { None, Business, Email, Finance, Games, Health, Productivity, Shopping, Social }

    public class Record : IComparable<Record>, ICloneable
    {
        private string serviceName;
        private string login;
        private string password;
        private string serviceURL;
        private categories category;
        
        public Record()
        {
            this.serviceName = "";
            this.login = "";
            this.password = "";
            this.serviceURL = "";
            this.category = categories.None;
        }

        public Record(string serviceName, string login, string password) : base()
        {
            this.serviceName = serviceName;
            this.login = login;
            this.password = password;
        }

        public Record(string serviceName, string login, string password, string serviceURL, categories category) : base()
        {
            this.serviceName = serviceName;
            this.login = login;
            this.password = password;
            this.serviceURL = serviceURL;
            this.category = category;
        }

        public override string ToString()
        {
            return serviceName;
        }

        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string ServiceURL { get => serviceURL; set => serviceURL = value; }
        public categories Category { get => category; set => category = value; }

        public int CompareTo(Record record)
        {
            return String.Compare(ServiceName, record.ServiceName);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
