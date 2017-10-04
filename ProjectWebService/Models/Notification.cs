using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWebService.Models
{
    public class Notification
    {
        public DateTime Date { get; private set; }
        public string ID { get; private set; }
        public string Alarm { get; private set; }
        public string Name { get; private set; }
        public string Department { get; private set; }
        public string Place { get; private set; }
        public DateTime Done { get; private set; }

        public Notification(string line)
        {
            string[] notification = SeperateString(line);
            Date = DateTime.Parse(notification[0]);
            ID = notification[1];
            Alarm = notification[2];
            Name = notification[3];
            Department = notification[4];
            Place = notification[5];
            Done = DateTime.Parse(notification[7]);
        }

        private string[] SeperateString(string input)
        {
            string[] splitString = input.Split('\t');
            return splitString;

        }
    }

}