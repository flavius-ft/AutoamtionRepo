// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.UIA2;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;

namespace TotalCommSpecflow
{
    public class TotalComm
    {
         private Application app;
         private Window mainwindow;
        private static readonly HttpClient client = new();
        public static TotalComm total = new();

        //"https://www.totalcommander.ch/beta/tc1050x64_b1.exe"))
        // https://www.ghisler.com/
        public static async Task Main()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "TotalCommand.exe");
            using var stream = await client.GetStreamAsync(@"https://www.totalcommander.ch/win/tcmd1000x64.exe");
            using var fileStream = new FileStream(tempPath, FileMode.CreateNew);
            await stream.CopyToAsync(fileStream);
            fileStream.Dispose();

            Process process = new();
            process.StartInfo.FileName = tempPath;
            process.StartInfo.Arguments = "/AHMGDU";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
        }

        public  void OpenTotalCommander()
        {
            ConditionFactory cf = new(new UIA3PropertyLibrary());
            this.app = Application.Launch(@"C:\Program Files\totalcmd\TOTALCMD64.EXE");
            this.mainwindow = app.GetMainWindow(new UIA3Automation());
           // @"/Window[1]/Pane/Pane/Pane/Pane"

            mainwindow.FindFirstByXPath(@"/Window[1]/Pane/Pane/Pane/Pane").DrawHighlight();
            mainwindow.FindFirstDescendant(cf.ByName("")).AsButton().Click();
                
        }



    }
}
