namespace TotalCommSpecflow.spex.StepDefinitions
{
    [Binding]
    public sealed class TotalCommStepDefinitions
    {
        TotalComm total = new();

        [Given(@"the URL (.*)")]
        public void GivenTheURLHttpsWww_Ghisler_Com(string url)
        {
            throw new PendingStepException();
        }

        [When(@"the download is finnished")]
        public void WhenTheDownloadIsFinnished()
        {
            throw new PendingStepException();
        }

        [Then(@"instal the app")]
        public void ThenInstalTheApp()
        {
            throw new PendingStepException();
        }



    }
}