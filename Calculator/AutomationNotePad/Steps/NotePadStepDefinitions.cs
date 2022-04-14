using System;
using TechTalk.SpecFlow;

namespace AutomationNotePad.Features
{
    [Binding]
    public class NotePadStepDefinitions
    {
        AutomationNoteP pad = new();     // nu pot instantia clasa 

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
        
        [Then(@"press X and don't save it")]
        [Obsolete]
        public void ThenPressXAndDonTSaveIt()
        {

        }
    }
}
