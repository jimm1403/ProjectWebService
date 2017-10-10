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
        int oldCount = 0;


        public void ReadLog()
        {
            int newCount = CountLines();
            int difference = newCount - oldCount;

            using (StreamReader reader = new StreamReader(@"C:\Users\jimmi\Documents\logfil.txt"))
            {
                reader.ReadLine();
                string data = reader.ReadLine();
                for (int i = 0; i < difference - 1; i++)
                {
                    logfileList.Add(new Notification(data));
                    data = reader.ReadLine();
                }

                oldCount = newCount;
            }
        }
        public List<Notification> GetList()
        {
            List<Notification> tempList = new List<Notification>();

            for (int i = 0; i < 20; i++)
            {
                tempList.Add(logfileList[i]);
            }
            return tempList;
        }

        public Notification Search(string name)
        {
            return logfileList.Find(x => x.Name == name);
        }

        public int CountLines()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\jimmi\Documents\logfil.txt"))
            {
                string[] dataSplit = reader.ReadToEnd().Split('\n');
                return dataSplit.Length - 1;
            }
        }
    }
}
