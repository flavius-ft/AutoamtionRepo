// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TotalCommSpecflow
{
    public class TotalComm
    {
        // private Application app;
        // private Window mainwindow;
        private static readonly HttpClient client = new();
        public static TotalComm total = new();

        //"https://www.totalcommander.ch/beta/tc1050x64_b1.exe"))
        // https://www.ghisler.com/
        public static async Task Main()
        {
            string tempPath = Path.GetTempPath();
            using var stream = await client.GetStreamAsync(@"https://www.totalcommander.ch/win/tcmd1000x64.exe");
            //  using var fileStream = new FileStream(@"C:\Users\User\Downloads\TotalCommand.exe", FileMode.CreateNew);
            using var fileStream = new FileStream(tempPath + "TotalCommander.exe", FileMode.CreateNew);
            await stream.CopyToAsync(fileStream);
            fileStream.Dispose();

            Process process = new();
            process.StartInfo.FileName = tempPath + "TotalCommander.exe";
            process.StartInfo.Arguments = "/AHMGDU";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();

        }




    }
}
