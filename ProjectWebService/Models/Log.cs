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
        List<string> logfileList = new List<string>();

        public List<string> ReadLog()
        {
            bool run = true;
            StreamReader reader = new StreamReader(@"C:\Users\jimmi\Documents\logfil.txt");
            while (run)
            {
                string data = reader.ReadLine();

                if (data != null)
                {
                    string[] dataSeperated = SeperateString(data);
                    CreateString(dataSeperated);
                }
                else
                {
                    run = false;
                }
            }
            
            return logfileList;
        }

        private string[] SeperateString(string input)
        {
            string[] splitString = input.Split('\t');
            return splitString;
        }
        private void CreateString(string [] logLine)
        {
            string finishedLogLine = "";
            StringBuilder creator = new StringBuilder();

            foreach (string line in logLine)
            {
                finishedLogLine += line + ", ";
                //creator.Append(line + ", ");
                
            }

            finishedLogLine += '/';
            logfileList.Add(finishedLogLine);
        }

    }
}