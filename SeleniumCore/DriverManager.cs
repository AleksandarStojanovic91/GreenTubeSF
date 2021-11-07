using OpenQA.Selenium;

namespace GreenTubeSLN.SeleniumCore
{
    public abstract class DriverManager
    {
        protected IWebDriver driver;

        public abstract void CreateWebDriver();

        public IWebDriver GetWebDriver() 
        {
            if (null == driver) 
            {
                CreateWebDriver();
            }
            return driver;
        }

        public void QuitWebDriver()
        {
            if (null != driver)
            {
                driver.Close();
                driver.Quit();
                driver = null;
            }
        }
    }
}
