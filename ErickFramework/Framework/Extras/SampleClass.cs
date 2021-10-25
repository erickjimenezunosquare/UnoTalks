using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//using OpenQA.Selenium.Chrome;

namespace Framework
{
    public static class SampleClass
    {

        public static void DummyTest()
        {
            //https://www.kenst.com/2015/03/installing-chromedriver-on-mac-osx/
            //brew install chromedriver

            ChromeDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com");
            driver.FindElement(By.Name("q")).SendKeys("Erick Eduardo Jiménez Rodríguez");

            Thread.Sleep(5000);

            driver.Quit();
        }
    }
}
