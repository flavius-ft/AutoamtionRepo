using System;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.UIA2;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using System.Threading;

namespace AutomationNotePad
{
    public class Notepad
    {
        private Application application;
        private Window mainwindow;

        static void Main(string[] args)
        {
            Notepad pad = new Notepad();
            pad.LaunchNotepad();
            pad.EnterText();
            pad.CLoseButton();
            pad.DontSave();
        }

        public void LaunchNotepad()
        {
            this.application = Application.Launch("notepad.exe");
            this.mainwindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

           // mainwindow.FindFirstDescendant(cf.ByName("Text Editor")).AsTextBox().Enter("Salut");
           // mainwindow.FindFirstDescendant(cf.ByName("Close")).AsButton().Click();
           // mainwindow.FindFirstDescendant(cf.ByName("Don't Save")).AsButton().Click();
        }

        public void EnterText()
        {
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainwindow.FindFirstDescendant(cf.ByName("Text Editor"))?.AsTextBox().Enter("Salut");
        }

        public void CLoseButton()
        {
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainwindow.FindFirstDescendant(cf.ByName("Close")).AsButton().Click();
        }

        public void DontSave()
        {
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainwindow.FindFirstDescendant(cf.ByName("Don't Save")).AsButton().Click();
        }
    }
}
