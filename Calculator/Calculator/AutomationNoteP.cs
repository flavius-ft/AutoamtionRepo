using System;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.UIA2;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using System.Threading;

namespace AutomationNotePad
{
    public class AutomationNoteP
    {
        private Application application;
        private Window mainwindow;

        static void Main()
        {
            AutomationNoteP pad = new();
            pad.LaunchNotepad();
            pad.EnterText(Convert.ToString(Console.ReadLine()));
            pad.SelectFile();
           // pad.DontSave();
        }

        public void LaunchNotepad()
        {
            this.application = Application.Launch("notepad.exe");
            this.mainwindow = application.GetMainWindow(new UIA3Automation());

           // mainwindow.FindFirstDescendant(cf.ByName("Text Editor")).AsTextBox().Enter("Salut");
           // mainwindow.FindFirstDescendant(cf.ByName("Close")).AsButton().Click();
           // mainwindow.FindFirstDescendant(cf.ByName("Don't Save")).AsButton().Click();
        }

        public void EnterText(string text)
        {
            ConditionFactory cf = new(new UIA3PropertyLibrary());
            mainwindow.FindFirstDescendant(cf.ByName("RichEdit Control"))?.AsTextBox().Enter(text);
        }

        public void SelectFile()
        {
            ConditionFactory cf = new(new UIA3PropertyLibrary());
            mainwindow.FindFirstDescendant(cf.ByName("File")).AsMenuItem().Click();
        }

        public void DontSave()
        {
            ConditionFactory cf = new(new UIA3PropertyLibrary());
            mainwindow.FindFirstDescendant(cf.ByName("Don't Save")).AsButton().Click();
        }
    }
}
