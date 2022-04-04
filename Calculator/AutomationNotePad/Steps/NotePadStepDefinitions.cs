using System;
using TechTalk.SpecFlow;

namespace AutomationNotePad.Features
{
    [Binding]
    public class NotePadStepDefinitions
    {
       

        [Given(@"open notepad")]
        [Obsolete]
        public void GivenOpenNotepad()
        {

        }


        [When(@"the text (.*) is enterd")]
        [Obsolete]
        public void WhenTheTextIsEnterd(string text)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"press X and don't save it")]
        [Obsolete]
        public void ThenPressXAndDonTSaveIt()
        {

        }
    }
}
