using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalSpecFlowDemo.Pages;
using TurnUpPortalSpecFlowDemo.Utilities;

namespace TurnupPortalSpecFlow.StepDefinitions
{
    [Binding]
    public class TMStepDefinitions : CommonDriver
    {
        LoginPage loginPageObject = new LoginPage();
        HomePage homePageObject = new HomePage();
        TimeMaterialPage tmPageObject = new TimeMaterialPage();

        [BeforeScenario]
        public void SetUpTimeMaterial()
        {
            //Open Chrome Browser
            webDriver = new ChromeDriver();
        }

        [Given(@"I log into Turnup portal")]
        public void GivenILogIntoTurnupPortal()
        {
            loginPageObject.LoginActions(webDriver, "hari", "123123");
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObject.NavigateToTimeMaterialPage(webDriver);
        }

        [When(@"I create a new Time and Material record '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenICreateANewTimeAndMaterialRecord(String code, String description, String price)
        {
            tmPageObject.CreateTimeRecord(webDriver, code, description, price);

        }

        [Then(@"the record should be saved '([^']*)'")]
        public void ThenTheRecordShouldBeSaved(String code)
        {
            tmPageObject.AssertCreateTimeRecord(webDriver, code);
            webDriver.Quit();
        }

        [When(@"I edit an existing Time and Material record '([^']*)' '([^']*)'")]
        public void WhenIEditANewTimeAndMaterialRecord(string oldCode, String newCode)
        {
            tmPageObject.EditTimeRecord(webDriver, oldCode, newCode);
        }

        [Then(@"the record should be updated '([^']*)'")]
        public void ThenTheRecordShouldBeUpdated(string newCode)
        {
            tmPageObject.AssertEditTimeRecord(webDriver, newCode);
        }

        [When(@"I delete an existing Time and Material record '([^']*)'")]
        public void WhenIDeleteAnExistingTimeAndMaterialRecord(string code)
        {
            tmPageObject.DeleteTimeRecord(webDriver, code);
        }

        [Then(@"the record should be deleted '([^']*)'")]
        public void ThenTheRecordShouldBeDeleted(string code)
        {
            tmPageObject.AssertDeleteTimeRecord(webDriver, code);
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            webDriver.Quit();
        }
    }
}