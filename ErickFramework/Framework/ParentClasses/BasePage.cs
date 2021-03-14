//using SeleniumExtras.PageObjects; //new nuget
using OpenQA.Selenium.Support.PageObjects; //obsolete

namespace Framework
{
    public abstract class BasePage : IPage
    {
        public Browser Browser { get; set; }

        protected BasePage(Browser browser)
        {
            this.Browser = browser;
            InitElements(); //was not originally here
        }

        public void InitElements()
        {
            PageFactory.InitElements(Browser.Driver, this);
        }       
    }
}
