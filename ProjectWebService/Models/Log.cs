using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace ProjectWebService.Models
{
    public class Log
    {
        List<Notification> logfileList = new List<Notification>();

        public void ReadLog()
        {
            bool run = true;
            StreamReader reader = new StreamReader(@"C:\Users\jimmi\Documents\logfil.txt");
            reader.ReadLine();
            while (run)
            {
                string data = reader.ReadLine();

                if (data != null)
                {
                    Notification notification = new Notification(data);
                    logfileList.Add(notification);
                }
                else
                {
                    run = false;
                }
            }
        }

        public Notification Search(string name)
        {
            return logfileList.Find(x => x.Name == name);
        }
    }
}