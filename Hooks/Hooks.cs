using GreenTubeSLN.SeleniumCore;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace GreenTubeSF.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        IWebDriver driver;
        DriverManager driverManager;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driverManager = DriverManagerFactory.GetDriverManager("Chrome");
            driver = driverManager.GetWebDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driverManager.QuitWebDriver();
        }
    }
}
