using OpenQA.Selenium.Chrome;

namespace GreenTubeSLN.SeleniumCore
{
    public class ChromeDriverManager : DriverManager
    {
        public override void CreateWebDriver()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }
    }
}
