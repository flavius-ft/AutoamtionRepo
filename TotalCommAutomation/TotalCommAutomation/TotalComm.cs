// See https://aka.ms/new-console-template for more information
using System;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.UIA2;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using System.Threading.Tasks;
using FlaUI.Core.Input;
using System.Net.Http;

namespace TotalCommSpecflow
{
    public class TotalComm
    {
        private Application app;
        private Window mainwindow;
        private static readonly HttpClient client = new();

        public static void Main()
        {
            Task task = new(DownloadPageAsync);
            task.Start();
            Console.WriteLine();
            Console.ReadLine();
        }



        static async void DownloadPageAsync()
        {
            using(client)
                using(HttpResponseMessage response = await client.GetAsync("https://www.totalcommander.ch/beta/tc1050x64_b1.exe"))
                using(HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();
                if (result != null)
                {
                    Console.WriteLine(result);
                }
            }
            
        }

    }


}
