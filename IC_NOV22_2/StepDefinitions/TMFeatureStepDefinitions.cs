using IC_NOV22_2.Utilities;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace IC_NOV22_2.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into the TurnUp portal successsfully")]
        public void GivenILoggedIntoTheTurnUpPortalSuccesssfully()
        {
            driver = new ChromeDriver();
            Loginpage Loginpageobj = new Loginpage();
            Loginpageobj.LoginActions(driver);
        }

        [When(@"I navigate to the Time and Material page")]
        public void WhenINavigateToTheTimeAndMaterialPage()
        {
            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoTmPage(driver);
        }

        [When(@"I create to Tiime and Material Page")]
        public void WhenICreateToTiimeAndMaterialPage()
        {
            TMpage Tmpageobj = new TMpage();
            Tmpageobj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMpage Tmpageobj = new TMpage();
            string newcode = Tmpageobj.GetCode(driver);
            Assert.That(newcode == "2021NOV27", "Actual code and expected code do not match.");
        }
        [When(@"I update '([^']*)' in last created record")]
        public void WhenIUpdateInLastCreatedRecord(string Description)
        {
            TMpage Tmpageobj = new TMpage();
            Tmpageobj.EditTM(driver, Description);
        }
        [Then(@"The record should have updated '([^']*)' successfully")]
        public void ThenTheRecordShouldHaveUpdatedSuccessfully(string Description)
        {
            TMpage Tmpageobj = new TMpage();
            string editDescription = Tmpageobj.getEditedDescription(driver);
            Assert.That(editDescription == Description, "Actual code and expected code do not match.");
        }


    }
}
