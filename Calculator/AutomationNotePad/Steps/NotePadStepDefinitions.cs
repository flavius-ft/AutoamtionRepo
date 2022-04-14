using System;
using TechTalk.SpecFlow;

namespace AutomationNotePad.Features
{
    [Binding]
    public class NotePadStepDefinitions
    {
        readonly AutomationNoteP pad = new();     

        [Given(@"open notepad")]
        [Obsolete]
        public void GivenOpenNotepad()
        {
            pad.LaunchNotepad();
        }


        [When(@"the text (.*) is enterd")]
        [Obsolete]
        public void WhenTheTextIsEnterd(string text)
        {
            pad.EnterText(text);
        }

        [Then(@"close tha app")]
        public void ThenCloseThaApp()
        {
            pad.CloseTheApp();
        }


    }
}
