using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TurnUpPortalSpecFlowDemo.Pages
{
    public class HomePage
    {
        public void NavigateToTimeMaterialPage(IWebDriver webDriver)
        {
            try
            {
                //Navigate to Time and Material module (Click Administration button -> Select Time & Material Option)
                IWebElement administrationDropdown = webDriver.FindElement(By.XPath("//body/div[3]/div[1]/div[1]/ul[1]/li[5]/a[1]"));
                administrationDropdown.Click();
                WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));

                IWebElement tmOption = webDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
                tmOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp portal page did not displayed" + ex.Message);
            }
        }

        public void NavigateToEmployeePage(IWebDriver webDriver)
        {
            try
            {
                //Navigate to Time and Material module (Click Administration button -> Select Employee Option)
                IWebElement administrationDropdown = webDriver.FindElement(By.XPath("//body/div[3]/div[1]/div[1]/ul[1]/li[5]/a[1]"));
                administrationDropdown.Click();
                WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")));

                IWebElement employeeOption = webDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
                employeeOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp portal page did not displayed" + ex.Message);
            }
        }

        public void VerifyLoggedInUser(IWebDriver webDriver)
        {
            try
            {
                //Check if user has logged in successfully
                IWebElement helloHariLink = webDriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
                Console.WriteLine("User Logged in to TurnUp portal successfully.");
                Assert.That(helloHariLink.Text == "Hello hari!", "User hasn't been logged in.");
            }
            catch (Exception ex) 
            { 
                Assert.Fail("User hasn't logged in :(" + ex.Message); 
            }
        }

    }
}
