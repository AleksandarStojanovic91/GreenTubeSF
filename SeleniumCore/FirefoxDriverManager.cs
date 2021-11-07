using OpenQA.Selenium.Firefox;

namespace GreenTubeSLN.SeleniumCore
{
    public class FirefoxDriverManager : DriverManager
    {
        public override void CreateWebDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArguments("start-maximized");
            this.driver = new FirefoxDriver(options);
        }
    }
}
