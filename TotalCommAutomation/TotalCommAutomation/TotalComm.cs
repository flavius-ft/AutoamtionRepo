// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Accessibility;
using System.Management.Automation;

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
            using var stream = await client.GetStreamAsync(@"https://www.totalcommander.ch/win/tcmd1000x64.exe");
            using var fileStream = new FileStream(@"C:\Users\User\Downloads\TotalCommand.exe", FileMode.CreateNew);
            await stream.CopyToAsync(fileStream);
            fileStream.Dispose();

            ProcessFolder();
        }

        private static void ProcessFolder()
        {
            const string SOURCEFOLDERPATH = @"C:\Users\User\Downloads";

            if (Directory.Exists(SOURCEFOLDERPATH))
            {
                Console.WriteLine("Directory exists at: {0}", SOURCEFOLDERPATH);
                if (Directory.GetFiles(SOURCEFOLDERPATH, "*.exe").Length > 0)
                {
                    int count = Directory.GetFiles(SOURCEFOLDERPATH, "*.exe").Length;
                    string[] files = Directory.GetFiles(SOURCEFOLDERPATH, "*.exe");

                    foreach (var file in files)
                    {
                        var fileName = System.IO.Path.GetFileName(file);
                        var fileNameWithPath = SOURCEFOLDERPATH + "\\" + fileName;
                        Console.WriteLine("File Name: {0}", fileName);
                        Console.WriteLine("File name with path : {0}", fileNameWithPath);
                        //Deploy application  
                        Console.WriteLine("Wanna install {0} application on this VM?   Press any key to contiune.", fileName);  
                            Console.ReadKey(); 
                        DeployApplications(fileNameWithPath); 
                        Console.ReadLine();
                    }
                }

            }
            else
                Console.WriteLine("Directory does not exist at: {0}", SOURCEFOLDERPATH);

        }


        public static void DeployApplications(string executableFilePath)
        {
            PowerShell powerShell = null;
            Console.WriteLine(" ");
            Console.WriteLine("Deploying application...");
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    //here “executableFilePath” need to use in place of “  
                    //'C:\\ApplicationRepository\\FileZilla_3.14.1_win64-setup.exe'”  
                    //but I am using the path directly in the script.  
                    powerShell.AddScript("$setup=Start-Process 'C:\\Users\\User\\Downloads\\TotalCommand.exe ' -ArgumentList ' /AHMGDU ' -Wait -PassThru");  


                        Collection < PSObject > PSOutput = powerShell.Invoke(); foreach (PSObject outputItem in PSOutput)
                    {

                        if (outputItem != null)
                        {

                            Console.WriteLine(outputItem.BaseObject.GetType().FullName);
                            Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
                        }
                    }

                    if (powerShell.Streams.Error.Count > 0)
                    {
                        string temp = powerShell.Streams.Error.First().ToString();
                        Console.WriteLine("Error: {0}", temp);

                    }
                    else
                        Console.WriteLine("Installation has completed successfully.");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.InnerException);
                //throw;  
            }
            finally
            {
                if (powerShell != null)
                    powerShell.Dispose();
            }

        }


    }
}