using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TurnUpPortalSpecFlowDemo.Utilities
{
    public class WaitUtils
    {
        private static readonly string XPATH = "XPath";
        private static readonly string ID = "Id";
        private static readonly string CSS_SELECTOR = "CssSelector";
        private static readonly string NAME = "Name";

        public static void WaitToBeVisible(IWebDriver webDriver, string locatorType, string locatorValue, int seconds)
        {
            WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));

            if (locatorType == XPATH)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locatorType == ID)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
            if (locatorType == CSS_SELECTOR)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }
            if (locatorType == NAME)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));
            }
        }

        public static void WaitToBeClickable(IWebDriver webDriver, string locatorType, string locatorValue, int seconds)
        {
            WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));

            if (locatorType == XPATH)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locatorType == ID)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locatorType == CSS_SELECTOR)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
            if (locatorType == NAME)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
            }
        }

        public static void WaitToExist(IWebDriver webDriver, string locatorType, string locatorValue, int seconds)
        {
            WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));

            if (locatorType == XPATH)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locatorType == ID)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locatorType == CSS_SELECTOR)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }
            if (locatorType == NAME)
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name(locatorValue)));
            }
        }
    }
}
