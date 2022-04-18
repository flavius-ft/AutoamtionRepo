using System;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.UIA2;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using System.Threading;
using FlaUI.Core.Input;

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
            pad.ChangeTheme();
           // pad.EnterText(Convert.ToString(Console.ReadLine()));
            //pad.CloseTheApp();
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

        public void CloseTheApp()
        {
            ConditionFactory cf = new(new UIA3PropertyLibrary());
            mainwindow.FindFirstDescendant(cf.ByName("Close")).AsButton().Invoke();

            mainwindow.FindFirstDescendant(cf.ByAutomationId("SecondaryButton")).AsButton().Invoke();
        }

        public void ChangeTheme()
        {
            ConditionFactory cf = new(new UIA3PropertyLibrary());
            mainwindow.FindFirstDescendant(cf.ByAutomationId("SettingsButton")).AsButton().Invoke();
            mainwindow.FindFirstDescendant(cf.ByAutomationId("Expander")).DrawHighlight().Click();
            mainwindow.FindFirstDescendant(cf.ByAutomationId("DarkButton")).AsRadioButton().Click();
            

        }

        public void Close()
        {
            mainwindow.Close();
        }

    }
}
