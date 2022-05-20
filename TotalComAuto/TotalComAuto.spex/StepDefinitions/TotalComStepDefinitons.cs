using TotalCommSpecflow;

namespace TotalComAuto.spex.StepDefinitions
{
    [Binding]
    public sealed class TotalComStepDefinitons
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        TotalComm app = new();

        [Given(@"the application TotalCommander")]
        public void GivenTheApplicationTotalCommander()
        {
            app.OpenTotalCommander();
        }

        [When(@"navigate do download folder")]
        public void WhenNavigateDoDownloadFolder()
        {
            throw new PendingStepException();
        }

        [Then(@"delete Automation folder")]
        public void ThenDeleteAutomationFolder()
        {
            throw new PendingStepException();
        }

    }
}