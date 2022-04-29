// See https://aka.ms/new-console-template for more information
using System;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.UIA2;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using System.Threading;
using FlaUI.Core.Input;

namespace TotalCommSpecflow
{
    public class TotalComm
    {
        private Application app;
        private Window mainwindow;
        private static readonly HttpClient httpClient;

        static TotalComm()
        {
            httpClient = new HttpClient();
        }
        public static void Main()
        {
            TotalComm total = new();

            total.GetTotalCommander("https://www.totalcommander.ch/beta/tc1050x64_b1.exe");
        }



        public Task<HttpResponseMessage> GetTotalCommander(string url)
        {
            return httpClient.GetAsync(url);
        }

    }


}
