﻿using System;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.UIA2;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Application application = Application.Launch("notepad.exe");
            var mainwindow = application.GetMainWindow(new UIA3Automation());

            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainwindow.FindFirstDescendant(cf.ByName("Text Editor")).AsTextBox().Enter("Salut. Ce mai faci?");
            mainwindow.FindFirstDescendant(cf.ByName("Close")).AsButton().Click();
            mainwindow.FindFirstDescendant(cf.ByName("Don't Save")).AsButton().Click();

        }
    }
}
