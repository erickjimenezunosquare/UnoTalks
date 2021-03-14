using Framework;
using Framework.Logger;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestCases.ParentClasses;

namespace TestCases
{
    [TestFixture()]
    public class Test : ErickTest
    {
        #region Initialization

        [OneTimeSetUp]
        public void BeforeEachSuite()
        {
            InitializeFramework();
        }

        [SetUp]
        public void BeforeEachTest()
        {
            Pages.BankHomePage.InitElements();
            Pages.BankCreditCards.InitElements();
        }
        #endregion Initialization

        [Test()]
        public void SearchInGoogle()
        {
            Log.Info("Erick Jiménez Rodríguez");

            SampleClass.DummyTest();

            Log.Info("Dummy test passed!");
        }

        [Test()]
        public void ReportCreditCard_Combination1_NoReplacement()
        {
            Pages.BankHomePage
                .LoginWithCredentials("user1", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(askForReplacement: false);
        }

        [Test()]
        public void ReportCreditCard_Combination2_Rush_OriginalAddress()
        {
            Pages.BankHomePage
                .LoginWithCredentials("user1", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(askForReplacement: true, Framework.Pages.DeliveryTypes.Rush);
        }

        [Test()]
        public void ReportCreditCard_Combination3_Rush_NewAddress()
        {
            List<string> newAddressLines = new List<string>
            {
                "123 Main St",
                "Apt. 3",
                "90210",
                "Beverly Hills",
                "CA"
            };

            Pages.BankHomePage
                .LoginWithCredentials("user1", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(askForReplacement: true, Framework.Pages.DeliveryTypes.Rush, newAddressLines);
        }

        [Test()]
        public void ReportCreditCard_Combination4_Free_OriginalAddress()
        {
            Pages.BankHomePage
                .LoginWithCredentials("user1", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(askForReplacement: true, Framework.Pages.DeliveryTypes.Free);
        }

        [Test()]
        public void ReportCreditCard_Combination5_Free_NewAddress()
        {
            List<string> newAddressLines = new List<string>
            {
                "123 Main St",
                "Apt. 3",
                "90210",
                "Beverly Hills",
                "CA"
            };

            Pages.BankHomePage
                .LoginWithCredentials("user1", "MyPa$$W0rd123")
                .DoSomething();

            Pages.BankCreditCards
                .ReportCardAsLostOrStolen(askForReplacement: true, Framework.Pages.DeliveryTypes.Free, newAddressLines);
        }

        #region Tear Down

        [TearDown]
        public void AfterEachTest()
        {
            WaitFewSeconds();
            CleanupTest();
        }

        [OneTimeTearDown]
        public void AfterEachSuite()
        {
            Log.Info("All scripts ran succesfully");
        }
        #endregion Tear Down
    }
}
