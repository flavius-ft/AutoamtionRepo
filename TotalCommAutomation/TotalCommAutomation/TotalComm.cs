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
       // private Application app;
       // private Window mainwindow;
        private static readonly HttpClient client = new();

        //"https://www.totalcommander.ch/beta/tc1050x64_b1.exe"))
        // https://www.ghisler.com/
        public static async Task Main()
        {
            using var stream = await client.GetStreamAsync(@"https://www.totalcommander.ch/beta/tc1050x64_b1.exe");
            using var fileStream = new FileStream(@"C:\Users\User\Downloads\Automation\tc1050x64_b1.exe", FileMode.CreateNew);
            await stream.CopyToAsync(fileStream);
        }

           
    }
}
