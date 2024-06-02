using OpenQA.Selenium;

namespace TurnUpPortalSpecFlowDemo.Pages
{
    public class LoginPage
    {
        private readonly By userNameTextboxLocator = By.Id("UserName");
        IWebElement usernameTextbox;
        private readonly By passwordTextboxLocator = By.Id("Password");
        IWebElement passwordTextbox;
        private readonly By loginButtonLocator = By.XPath("//*[@id='loginForm']/form/div[3]/input[1]");
        IWebElement loginButton;

        public void LoginActions(IWebDriver webDriver, string username, string password)
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //Launch turnUp Portal and navigate to login page
            string baseURL = "http://horse.industryconnect.io/Account/Login";
            webDriver.Navigate().GoToUrl(baseURL);

            //Identify username textbox and enter valid username
            usernameTextbox = webDriver.FindElement(userNameTextboxLocator);
            usernameTextbox.SendKeys(username);

            //Identify password textbox and enter valid password
            passwordTextbox = webDriver.FindElement(passwordTextboxLocator);
            passwordTextbox.SendKeys(password);

            //Identify login button and click on the button
            loginButton = webDriver.FindElement(loginButtonLocator);
            loginButton.Click();
        }

    }
}
