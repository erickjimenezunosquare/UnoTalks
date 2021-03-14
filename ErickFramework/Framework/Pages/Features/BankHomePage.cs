using System;
using Framework.Logger;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public class BankHomePage : BasePage, IPage
    {
        //Constructor
        public BankHomePage(Browser browser):base (browser)
        {
        }

        //Method from interface
        public override void GoTo()
        {
            throw new NotImplementedException();
        }

        #region Element locators

        [FindsBy(How = How.Id, Using = "username")]
        private readonly IWebElement _inputUsername;

        [FindsBy(How = How.Name, Using = "password")]
        private readonly IWebElement _inputPassword;

        [FindsBy(How = How.Name, Using = "q")]
        private readonly IWebElement _inputSearchBar;

        #endregion Element locators

        #region Element accessors

        public IWebElement InputUsername => _inputUsername;

        public IWebElement InputPassword => _inputPassword;

        public IWebElement InputSearchBar => _inputSearchBar;

        #endregion Element accessors

        #region Page Methods

        public BankHomePage LoginWithCredentials(string username, string password)
        {
            const bool useElementDirectly = false;

            Log.Info($"Logging in with user: {username}");
            Log.Info($"Logging in with password: {password}");

            Browser.GoToUrl();

            if(useElementDirectly)
            {
                Browser.Driver.FindElement(By.Name("q")).SendKeys("hardcodeado");
                Browser.WaitTime(3);
            }

            InputSearchBar.SendKeys("Simulating a search instead of a login...");
            return this;

            InputUsername.SendKeys(username);
            InputPassword.SendKeys(password);
        }

        public BankHomePage DoSomething() { return this;  }

        public BankHomePage DoSomething2() { return this; }

        public BankHomePage DoSomething3() { return this; }

        public BankHomePage DoSomething4() { return this; }

        #endregion Page Methods
    }
}
