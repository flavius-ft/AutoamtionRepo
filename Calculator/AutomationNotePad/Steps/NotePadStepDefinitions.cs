using System;
using TechTalk.SpecFlow;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.UIA2;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using System.Threading;

namespace AutomationNotePad.Features
{
    [Binding]
    public class NotePadStepDefinitions
    {
        Application application = new Application();

        ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

        [Given(@"open notepad")]
        [Obsolete]
        public void GivenOpenNotepad()
        {
            
            
        }

        var mainwindow = application.GetMainWindow(new UIA3Automation());

        [When(@"the text is enterd")]
        [Obsolete]
        public void WhenTheTextIsEnterd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"press X and don't save it")]
        [Obsolete]
        public void ThenPressXAndDonTSaveIt()
        {
            mainwindow.FindFirstDescendant(cf.ByName("Text Editor")).AsTextBox().Enter("Salut. Ce mai faci?");
        }
    }
}
