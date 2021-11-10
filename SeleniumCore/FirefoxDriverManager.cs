using OpenQA.Selenium.Firefox;

namespace GreenTubeSLN.SeleniumCore
{
    public class FirefoxDriverManager : DriverManager
    {
        public override void CreateWebDriver()
        {
            this.driver = new FirefoxDriver();
            this.driver.Manage().Window.Maximize();
        }
    }
}
