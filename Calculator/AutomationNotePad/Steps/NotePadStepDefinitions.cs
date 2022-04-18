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

        [When(@"change the theme to dark")]
        public void WhenChangeTheThemeToDark()
        {
            pad.ChangeTheme();
        }


        [Then(@"close the app")]
        public void ThenCloseTheApp()
        {
            pad.Close();
        }




    }
}
