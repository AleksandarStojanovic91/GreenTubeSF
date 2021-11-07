using BoDi;
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

        private readonly IObjectContainer container;

        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driverManager = DriverManagerFactory.GetDriverManager("Chrome");
            driver = driverManager.GetWebDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver = container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
