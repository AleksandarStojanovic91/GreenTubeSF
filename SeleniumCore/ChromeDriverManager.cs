using OpenQA.Selenium.Chrome;

namespace GreenTubeSLN.SeleniumCore
{
    public class ChromeDriverManager : DriverManager
    {
        public override void CreateWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            this.driver = new ChromeDriver(options);
        }
    }
}
