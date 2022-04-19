﻿// See https://aka.ms/new-console-template for more information
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
        private static readonly HttpClient httpClient = new();
        public static void Main()
        {
            TotalComm total = new();

            total.GetTotalCommander("https://www.totalcommander.ch/beta/tc1050x64_b1.exe");
        }

        public void GetTotalCommander(string url)
        {
            httpClient.GetAsync(url);
        }

        public void EnterUrl()
        {
            ConditionFactory cf = new(new UIA3PropertyLibrary());

            mainwindow.FindFirstDescendant(cf.ByName("Address and search bar")).DrawHighlight();
        }

        public string Url(string url)
        {
            return Convert.ToString(Console.Read()); 
        }

    }


}