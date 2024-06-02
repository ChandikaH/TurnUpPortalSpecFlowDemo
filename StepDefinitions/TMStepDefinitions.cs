using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Reflection.Emit;
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

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            loginPageObject.LoginActions(webDriver, "hari", "123123");
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObject.NavigateToTimeMaterialPage(webDriver);
        }

        [When(@"I create a new time and material record ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void WhenICreateANewTimeAndMaterialRecord(String code, String typeCode, String description, String price)
        {
            tmPageObject.CreateTimeRecord(webDriver, code, typeCode, description, price);
        }

        [Then(@"The record should be created successfully ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void ThenTheRecordShouldBeCreatedSuccessfully(String code, String typeCode, String description, String price)
        {
            tmPageObject.AssertCreateTimeRecord(webDriver, code, typeCode, description, price);
        }

        [When(@"I edit an existing time and material record ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void WhenIEditAnExistingTimeAndMaterialRecord(String oldCode, String oldTypeCode, String oldDescription, String oldPrice, String newCode, String newTypeCode, String newDescription, String newPrice)
        {
            tmPageObject.EditTimeRecord(webDriver, oldCode, oldTypeCode, oldDescription, oldPrice, newCode, newTypeCode, newDescription, newPrice);
        }

        [Then(@"The record should be updated successfully ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void ThenTheRecordShouldBeUpdatedSuccessfully(String newCode, String newTypeCode, String newDescription, String newPrice)
        {
            tmPageObject.AssertEditTimeRecord(webDriver, newCode, newTypeCode, newDescription, newPrice);
        }

        [When(@"I delete an existing time and material record '([^']*)'")]
        public void WhenIDeleteAnExistingTimeAndMaterialRecord(String code)
        {
            tmPageObject.DeleteTimeRecord(webDriver, code);
        }

        [Then(@"The record should be deleted successfully ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void ThenTheRecordShouldBeDeletedSuccessfully(String code, String typeCode, String description, String price)
        {
            tmPageObject.AssertDeleteTimeRecord(webDriver, code, typeCode, description, price);
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            webDriver.Quit();
        }
    }
}