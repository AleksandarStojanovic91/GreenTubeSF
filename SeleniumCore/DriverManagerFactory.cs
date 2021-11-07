using System;

namespace GreenTubeSLN.SeleniumCore
{
    public class DriverManagerFactory
    {
        public static DriverManager GetDriverManager(string browser) 
        {
            DriverManager driverManager;

            switch (browser)
            {
                case "Chrome":
                    driverManager = new ChromeDriverManager();
                    break;
                case "Firefox":
                    driverManager = new FirefoxDriverManager();
                    break;
                default:
                    throw new Exception("Browser type: "+browser+" not supported!");
            }

            return driverManager;
        }
    }
}
