using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace UsizoConsoleClient
{
    class Program
    {
        static HttpClient client = new HttpClient();
        string logFile;
        List<string> logFileList = new List<string>();


        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("hello, click enter when api is ready");
            Console.ReadLine();
            program.GetLogFile();

        }

        public void GetLogFile()
        {
            client.BaseAddress = new Uri("http://localhost:4139/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            MyAPIGet(client).Wait();
        }

        public async Task MyAPIGet(HttpClient client)
        {
            using (client)
            {
                HttpResponseMessage response = await client.GetAsync("api/log");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    logFile = await response.Content.ReadAsStringAsync();

                }
            }
            ConvertLogStringToList();
            Console.ReadLine();
        }
        public void ConvertLogStringToList()
        {
            string[] loglines = logFile.Split('\n');
            foreach (string line in loglines)
            {
                logFileList.Add(line);
            }
            foreach (var line in logFileList)
            {
                Console.WriteLine(line);
            }
        }
        
    }
}
