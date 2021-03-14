using System;
using System.Collections.Generic;
using Framework.Logger;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public class BankCreditCards : BasePage, IPage
    {
        public BankCreditCards(Browser browser):base (browser)
        {
        }

        public override void GoTo()
        {
            throw new NotImplementedException();
        }

        #region Element locators

        [FindsBy(How = How.Id, Using = "btn-1")]
        private readonly IWebElement _button1;

        [FindsBy(How = How.Name, Using = "btn-2")]
        private readonly IWebElement _button2;

        #endregion Element locators

        #region Element accessors

        public IWebElement Button1 => _button1;

        public IWebElement Button2 => _button2;

        #endregion Element accessors

        #region Page Methods

        public BankCreditCards OpenCreditCard(string last4Digits)
        {            
            return this;
        }

        public BankCreditCards ReportCardAsLostOrStolen(bool askForReplacement, DeliveryTypes deliveryType = DeliveryTypes.Free, List<string> newAddress = null)
        {
            Log.Info("askForReplacement: " + askForReplacement.ToString().ToUpper());
            Log.Info("deliveryType: " + deliveryType.ToString());

            if(newAddress != null && newAddress.Count >= 1)
                newAddress.ForEach(x => Log.Info("newAddress: " + x));

            return this;
        }

        public BankCreditCards AskForCardReplacement(string reasonOfChange, DeliveryTypes deliveryType, List<string> newAddress = null)
        {
            Log.Info("reasonOfChange: " + reasonOfChange);
            Log.Info("deliveryType: " + deliveryType.ToString());

            if (newAddress != null && newAddress.Count >= 1)
                newAddress.ForEach(x => Log.Info("newAddress: " + x));

            return this;
        }

        public BankCreditCards DoSomething() { return this; }

        public BankCreditCards DoSomething2() { return this; }

        public BankCreditCards DoSomething3() { return this; }

        public BankCreditCards DoSomething4() { return this; }

        #endregion Page Methods
    }

    public enum CardNetworks
    {
        Visa,
        Mastercard
    }

    public enum DeliveryTypes
    {
        Rush,
        Free
    }
}
