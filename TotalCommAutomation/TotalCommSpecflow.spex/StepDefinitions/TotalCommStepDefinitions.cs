namespace TotalCommSpecflow.spex.StepDefinitions
{
    [Binding]
    public sealed class TotalCommStepDefinitions
    {
        TotalComm total = new();

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }

        [Given(@"the URL (.*)")]
        public void GivenTheURLHttpsWww_Ghisler_Com(string url)
        {
            total.OpenWeb();
            total.EnterUrl();
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